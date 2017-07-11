using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SimToDo
{
    public partial class Todo : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Todo()
        {
            InitializeComponent();

            string cs = ConfigurationManager.ConnectionStrings["SimToDo.Properties.Settings.todoDB"].ToString();
            con = new SqlConnection(cs);
            

            display();
        }

        public void display()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd = new SqlCommand("select * from todo1", con);
            SqlDataReader dr = cmd.ExecuteReader();

            dataGridView1.DataSource = new BindingSource { DataSource = dr };
            
            clear();
        }

        public void clear()
        {
            tbxTodo.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd = new SqlCommand("insert into todo1 values(@name)",con);
            cmd.Parameters.AddWithValue("@name", tbxTodo.Text);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                label2.Text = "Added!";

            display();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd = new SqlCommand("delete from todo1 where name=@name", con);
            cmd.Parameters.AddWithValue("@name", tbxTodo.Text);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
                label2.Text = "Deleted!";

            display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxTodo.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
