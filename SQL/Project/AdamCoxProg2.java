/*
   Program Name: CreateTable.java
   Done by: Adam Cox
 */

import java.sql.*;
import java.util.Scanner;

public class AdamCoxProg2 {

	static final String URL = "jdbc:mariadb://localhost:3306/test";

	public static void main(String args[]) {

	    Scanner stdIn = new Scanner(System.in);
		String user;
		String password;
		Connection con = null;
		Statement stmt = null;
		String createString1 = "SELECT c.FirstName, c.LasstName, ContractNo, w.Days, w.Time, w.Workouts FROM client c JOIN contract o USING (clientID) JOIN workouttime w USING (ContractNo)";
        System.out.println("Enter MariaDB username:");
		user = stdIn.nextLine();
		System.out.println("Enter password:");
		password = stdIn.nextLine();



		try {
			Class.forName("org.mariadb.jdbc.Driver");

		} catch(java.lang.ClassNotFoundException e) {
			System.err.print("ClassNotFoundException: ");
			System.err.println(e.getMessage());
		}

		try {
			con = DriverManager.getConnection(URL, user, password);
			stmt = con.createStatement();
			ResultSet rs = stmt.executeQuery(createString1);
			ResultSetMetaData rsmd = rs.getMetaData();
			System.out.println("");
			int columnsNumber = rsmd.getColumnCount();
			int x = 1;
			while (rs.next()) {
				while (x <= columnsNumber) {
					if (x > 1) System.out.print(" | ");
			        String columnValue = rs.getString(x);
					String col = rsmd.getColumnName(x);
					int num = col.length();
			        System.out.print(rsmd.getColumnName(x));
					for(int a =1; a<=(12-num); a++)
					{
						System.out.print(" ");
						}
			        if(x==columnsNumber)System.out.println("");
			        x++;
			        }
			        for (int i = 1; i <= columnsNumber; i++) {

						if (i > 1) System.out.print(" | ");
						String columnValue = rs.getString(i);
						System.out.print(columnValue);

						int length = columnValue.length();
						for(int a =1; a<=(12-length); a++)
						{
							System.out.print(" ");
						}
						}
					System.out.println("");
				 }
			stmt.close();
			con.close();

		} catch(SQLException ex) {
			System.err.println("SQLException: " + ex.getMessage());
		}
	}
}