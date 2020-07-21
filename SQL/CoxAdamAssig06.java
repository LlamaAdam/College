/*
   Program Name: CreateTable.java
   Done by: Adam Cox
 */

import java.sql.*;
import java.util.Scanner;

public class CoxAdamAssig06 {

	static final String URL = "jdbc:mariadb://localhost:3306/forassig06";

	public static void main(String args[]) {

	    Scanner stdIn = new Scanner(System.in);
		String user;
		String password;
		Connection con = null;
		Statement stmt = null;
		String createString1 = "select b.ClientID,b.name,ContractNo, c.DateSigned FROM contract a join client b USING (ClientID) join longtermcontract c using (ContractNo) where b.Name like '%a%' group by contractno";
        String createString3 = "select l.Name, c.ContractNo, t.TripNo, t.destination from contract c join client l USING (clientid) join trip t USING (contractno) where t.tripno <= 5";
        String createString2 = "select s.contractno, s.destination, v.model, d.lastname from shorttermcontract s join driver d on s.driverassigned=d.documentid join vehicle v on s.VehicleAssigned=v.NumberPlate where v.MaxWeightLoad >= 1000";
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
					if (x > 1) System.out.print("	|	");
			        String columnValue = rs.getString(x);
			        System.out.print(rsmd.getColumnName(x));
			        if(x==columnsNumber)System.out.println("");
			        x++;
			        }
			        for (int i = 1; i <= columnsNumber; i++) {
						if (i > 1) System.out.print("	|	");
						String columnValue = rs.getString(i);
						System.out.print(columnValue);
						}
					System.out.println("");
				 }
			ResultSet rs2 = stmt.executeQuery(createString2);
						ResultSetMetaData rs2md = rs2.getMetaData();
						System.out.println("");
						int columnsNumber2 = rs2md.getColumnCount();
						int y = 1;
						while (rs2.next()) {
							while (y <= columnsNumber2) {
								if (y > 1) System.out.print("	|	");
						        String columnValue = rs2.getString(y);
						        System.out.print(rs2md.getColumnName(y));
						        if(y==columnsNumber)System.out.println("");
						        y++;
						        }
						        for (int i = 1; i <= columnsNumber; i++) {
									if (i > 1) System.out.print("	|	");
									String columnValue = rs2.getString(i);
									System.out.print(columnValue);
									}
								System.out.println("");
				 }
			ResultSet rs3 = stmt.executeQuery(createString3);
						ResultSetMetaData rs3md = rs3.getMetaData();
						System.out.println("");
						int columnsNumber3 = rs3md.getColumnCount();
						int z = 1;
						while (rs3.next()) {
							while (z <= columnsNumber3) {
								if (z > 1) System.out.print("	|	");
						        String columnValue = rs3.getString(z);
						        System.out.print(rs3md.getColumnName(z));
						        if(z==columnsNumber)System.out.println("");
						        z++;
						        }
						        for (int i = 1; i <= columnsNumber; i++) {
									if (i > 1) System.out.print("	|	");
									String columnValue = rs3.getString(i);
									System.out.print(columnValue);
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

