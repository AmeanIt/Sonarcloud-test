protected void btnSearch_Click(object sender, EventArgs e) {  
    SqlConnection conn = new SqlConnection(@"Data Source=ServerName\SQLEXPRESS;Initial Catalog=DemoDB;Integrated Security=SSPI;");  
    SqlCommand cmd = new SqlCommand("Select * from GridViewDynamicData where Field1= '" + txtSearch.Text +"'", conn);  
    conn.Open();  
    SqlDataAdapter ad = new SqlDataAdapter(cmd);  
    DataTable dt = new DataTable();  
    ad.Fill(dt);  
    if(dt.Rows.Count > 0)  
    {  
        GridView1.DataSource = dt;  
        GridView1.DataBind();  
    }  
  
    conn.Close();  
}  