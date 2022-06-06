
string Conn = "Data Source=OPALIUM;Initial Catalog=Assign9;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
            

//INSERT
            string insertQ = "INSERT INTO [Assets] (id,name,price,count) " + "VALUES('1','Aprt','800','1')";
            SqlCommand cmd = new SqlCommand(insertQ, conn);
            cmd.ExecuteNonQuery();

            
//UPDATE
            string updat1 = "UPDATE [Assets]"+" SET price='300' where id='1'";
            SqlCommand cmd1 = new SqlCommand(updat1, conn);
            cmd1.ExecuteNonQuery();
            string updat2 = "UPDATE [Assets]" + " SET price='40' where id='2'";
            SqlCommand cmd2 = new SqlCommand(updat2, conn);
            cmd2.ExecuteNonQuery();
            string updat3 = "UPDATE [Assets]" + " SET price='200' where id='3'";
            SqlCommand cmd3 = new SqlCommand(updat3, conn);
            cmd3.ExecuteNonQuery();


            
//DELETE
            string delet = "DELETE [Assets] WHERE id ='2'";
            SqlCommand cmd4 = new SqlCommand(delet, conn);
            cmd4.ExecuteNonQuery();
            string delet1 = "DELETE [Assets] WHERE id ='3'";
            SqlCommand cmd5 = new SqlCommand(delet1, conn);
            cmd5.ExecuteNonQuery();

            
//INSERT
            string insert = "INSERT INTO [Assets] (id,name,price,count) " + "VALUES('2','Money','40','22500')";
            SqlCommand cmd6 = new SqlCommand(insert, conn);
            cmd6.ExecuteNonQuery();

            
//UPDATE & INSERT
            string updat4 = "UPDATE [Assets]" + " SET price='280' where id='2'";
            SqlCommand cmd7 = new SqlCommand(updat4, conn);
            cmd7.ExecuteNonQuery();

            
            string insert1 = "INSERT INTO [Assets] (id,name,price,count) " + "VALUES('3','EOS','40','5')";
            SqlCommand cmd8 = new SqlCommand(insert1, conn);
            cmd8.ExecuteNonQuery();
            string insert2 = "INSERT INTO [Assets] (id,name,price,count) " + "VALUES('4','ETH','60','7')";
            SqlCommand cmd9 = new SqlCommand(insert2, conn);
            cmd9.ExecuteNonQuery();

            conn.Close();
