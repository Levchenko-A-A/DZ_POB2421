namespace HomeWork28_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TreeNode treeViewGardenEquipment = new TreeNode();
        }

        private void button_Click(object sender, EventArgs e)
        {
            treeViewGardenEquipment.ExpandAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeViewGardenEquipment.CollapseAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length != 0)
            {
                TreeNode rootNode = treeViewGardenEquipment.SelectedNode;
                TreeNode internalNode = new TreeNode(textBoxText.Text);
                rootNode.Nodes.Add(internalNode);
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = treeViewGardenEquipment.SelectedNode;
            rootNode.Nodes.Remove(rootNode);
        }
    }
}
