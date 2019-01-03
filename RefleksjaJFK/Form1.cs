using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Whatever;
using FirstClass;
using SecondClass;

namespace RefleksjaJFK {
    public partial class Form1 : Form {

        private Assembly assembly;
        private TreeNode markedView;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnOpen_Click(object sender, EventArgs e) {

            string[] files = null;
  
            using (var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    files = Directory.GetFiles(fbd.SelectedPath);

                    foreach (var filename in files) {
                        if (filename.EndsWith(".exe") || filename.EndsWith(".dll")) {
                            this.assembly = Assembly.LoadFrom(filename);
                            this.PopulateTree();
                        }
                    }
                }

            }

        }

        private void PopulateTree() {
            //this.treeView.Nodes.Clear();
            var newNode = new TreeNode(this.assembly.GetName().Name) { Tag = this.assembly };
            this.treeView.Nodes.Add(newNode);

            foreach (var type in this.assembly.GetExportedTypes()) {
                if (typeof(IValid).IsAssignableFrom(type))
                    AddType(type, newNode);
            }
        }

        private static void AddType(Type type, TreeNode parent) {
            var newNode = new TreeNode(type.Name) { Tag = type };
            var memberTypeNode = new TreeNode(".ctors");
            TreeNode memberNode;

            memberTypeNode = new TreeNode("Methods");
            foreach (var method in type.GetMethods()) {
                if (method.DeclaringType.ToString() != "System.Object") {
                    var count = method.GetParameters().Length;
                    var stringBuilder = new StringBuilder(method.Name).Append('(');
                    foreach (var param in method.GetParameters()) {
                        stringBuilder.Append(param.ParameterType);
                        if (param.Position < count - 1) {
                            stringBuilder.Append(", ");
                        }
                    }

                    stringBuilder.Append(')');
                    memberNode = new TreeNode(stringBuilder.ToString()) { Tag = method };
                    memberTypeNode.Nodes.Add(memberNode);
                }
                }

                newNode.Nodes.Add(memberTypeNode);

                parent.Nodes.Add(newNode);

            
        } 

        private static void AddModule(Module module, TreeNode parent) {
            var newNode = new TreeNode(module.Name) { Tag = module };
            parent.Nodes.Add(newNode);

            foreach (var type in module.GetTypes()) {
                AddType(type, newNode);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e) {

            if(markedView?.Tag is MethodInfo) {

                Type type = (Type)markedView.Parent.Parent.Tag;

                if(!(Activator.CreateInstance(type) is IValid validated)) {

                    throw new InvalidOperationException();

                }

                MethodInfo markedMethod = (MethodInfo)markedView.Tag;

                object[] parameters = new object[1];

                 var isNumeric = int.TryParse(boxArguments.Text, out int n);

                if (isNumeric) {

                    parameters[0] = n;

                } else {

                    parameters[0] = boxArguments.Text;

                }

                 
               
                try {

                    object toReturn = markedMethod.Invoke(validated, parameters);

                    boxResults.Text = toReturn.ToString();

                } catch(Exception) {

                    MessageBox.Show("Invalid argument; Expected: " + markedMethod.GetParameters()[0].ParameterType);

                }

            }



        }

        private void boxDescription_TextChanged(object sender, EventArgs e) {

            
            

        }

        private void boxArguments_TextChanged(object sender, EventArgs e) {

            

        }

        private void boxResults_TextChanged(object sender, EventArgs e) {

        }

        private void boxArguments_Enter(object sender, EventArgs e) {

            boxArguments.Text = "";
            boxArguments.ForeColor = Color.Black;

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {

            markedView = treeView.SelectedNode;

            if (treeView.SelectedNode?.Tag is Type) {

                Type type = (Type)treeView.SelectedNode.Tag;

                if (typeof(IValid).IsAssignableFrom(type)) {

                    var descripition = type.GetCustomAttribute<Whatever.DescriptionAttribute>(true);

                    if (descripition != null) {

                        boxDescription.Text = descripition.Description;

                    }

                }
            
            } else if (treeView.SelectedNode?.Tag is MethodInfo) {

                Type type = (Type)treeView.SelectedNode.Parent.Parent.Tag;

                if (typeof(IValid).IsAssignableFrom(type)) {

                    var descripition = type.GetCustomAttribute<Whatever.DescriptionAttribute>(true);

                    if (descripition != null) {

                        boxDescription.Text = descripition.Description;

                    }

                    MethodInfo methodArgs = (MethodInfo)treeView.SelectedNode.Tag;

                    if (methodArgs.GetParameters().Length > 0) {

                        string s = "(" + methodArgs.GetParameters()[0].ParameterType + " " + methodArgs.GetParameters()[0].Name + ")";
                        boxArguments.Text = s;
                        boxArguments.ForeColor = Color.Silver;

                    } else {

                        boxArguments.Text = "";
                    }

                } else {

                    boxDescription.Text = " ";
                }

            } else {

                boxDescription.Text = " ";

            }

        }
    }
}
