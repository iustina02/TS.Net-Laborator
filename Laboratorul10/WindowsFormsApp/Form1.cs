using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

using Laboratorul_6;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<Post> posts = new List<Post>();
        string connectionString = @"Data Source=JARVICE;Initial Catalog=PostComment;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        // Handler pentru evenimentul Load al ferestrei principale
        private void Form1_Load(object sender, EventArgs e)
        {
            posts = LoadPosts().ToList<Post>();
            dgp.DataSource = posts;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgc.DataSource = posts[0].Comments;
        }
        private static Laboratorul_6.Post[] LoadPosts()
        {
            PostCommentClient pc = new PostCommentClient();
            Laboratorul_6.Post[] p = pc.GetPosts();
            return p;

        }
        // Handler pentru evenimentul CellMouseClick din DatagridView numit dgp
        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            dgc.DataSource = null;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Comments where PostPostId =" + e.RowIndex.ToString(), sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgc.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Posts", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgp.DataSource = dtbl;
            }
        }
    }
}
