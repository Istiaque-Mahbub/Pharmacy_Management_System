# Pharmacy Managment System Using C#
In a pharmacy management system, there are 3 types of Users Administrator, Customer and Pharmacist. Every user has different activities. Administrators have the highest access. He has a dashboard where he can see the total numbers of users. Administrators can also add the pharmacist. He can view the use list and update his password. Finally, he can log out.
Pharmacists have a dashboard where they can see the graph of valid and expired medicine. He can also add medicine by giving some information and modifying the existing medicine. Pharmacists can see all the available medicine. He can sell the medicine to the customers and print the bill. After finishing all his tasks, he can log out from the system. All the medicines are store in the database
Customers play the most important role in the pharmacy management system.  First time the customer must sign up using the sign-up page by giving the valid information. After that he can sign-in the system and buy the valid medicines. He can print the bills in real-time and dates. The customer can change his password, and it will automatically be updated to the database.
All the registered users can sign-in and perform their task using the sign-up page. Sign-up page extracted all the users from the database and match with the inputs. __


For Sql script download the file script.sql. Create the tables.<br />
Add Medicine Query <br />

# Technology Used
C#: Core programming language <br />

.NET Framework/Core: Application framework<br />

SQL Server or SQLite: Database (choose one based on my project)<br />

Visual Studio: IDE for development

# Prerequisites
Visual Studio 2022 or later<br />

SQL Server (Express or any version)<br />

SQL Server Management Studio (SSMS)<br />

# Create medic table
create table medic( <br />
id int identity(1,1) primary key, <br />

mid varchar(250) not null, <br />

mname varchar(250) not null, <br />

mnumber varchar(250) not null, <br />

mDate varchar(250) not null, <br />

eDate varchar(250) not null, <br />

quantity bigint not null, <br />

perUnit bigint not null <br />
); <br />
 <br />
  <br />

  # Create users table
create table users(<br />
id int identity(1,1) primary key,<br />
userRole varchar(50) not null,<br />
name varchar(250) not null,<br />
dob varchar(250) not null,<br />
mobile bigint not null,<br />
email varchar(250) not null,<br />
username varchar(250) unique not null,<br />
pass varchar (250) not null<br />
);<br />
<br />
  <br />
# ScreenShot of Database
![image](https://github.com/user-attachments/assets/476a5d58-75d8-460f-9ae6-4c33aa0884ed)
![image](https://github.com/user-attachments/assets/11072aee-250d-4bac-8ba3-7260adf5ec4d)

<br />
<br />
  <br />
# SQL Qurey

<br />
  SignUp page<br />
select * from users<br />
select * from users where username = '" +textUserName.Text+"' and pass='"+textPassword.Text+"'<br />
UC_Dashboard<br />
select count(userRole) from users where userRole='Adminstrator'<br />
select count(userRole) from users where userRole='Pharmacist'<br />
select count(userRole) from users where userRole='Customer'<br />
UC_ViewUser<br />
select * from users where username like '"+txtUserName.Text+"%'<br />
delete from users where username='"+username+"'<br />
Profile<br />
select * from users where username='"+userNameLabel.Text+"'<br />
update users set userRole='" + role + "', name='" + name + "', dob='" + dob + "', mobile="+mobile+",email='"+email+"',pass='"+password+ "' where username='"+username+"'<br />
AddUser<br />
insert into users(userRole,name,dob,mobile,email,username,pass) values ('"+role+"','"+name+ "','"+dob+"',"+mobile+",'"+email+"','"+username+"','"+password+"')<br />
select * from users where username='"+txtUserName.Text+"'<br />
UC_P_DashBoard<br />
select count(mname) from medic where eDate >= getdate()<br />
select count(mname) from medic where eDate < getdate()<br />
UC_P_AddMedicine<br />
insert into medic (mid, mname, mnumber, mDate, eDate,quantity, perUnit) values('"+ mid + "','"+ mname + "', '"+ mnumber + "', '"+mdate+"', '"+edate+"',"+quantity+","+perunit+")<br />
UC_P_ViewMedicine<br />
select * from medic<br />
select * from medic where mname like '"+txtSearch.Text+"%'<br />
delete from medic where mid = '"+MedicineID+"'<br />
UC_P_UpadateMedicine<br />
select * from medic where mid='" + txtMedicineID.Text + "'<br />
update medic set mname='"+ name + "',mnumber='"+ number + "',mDate='"+ mdate + "',eDate='"+ edate + "',quantity="+ totalQuantity + ",perUnit="+ unitprice + " where mid='"+txtMedicineID.Text+"'<br />
UC_MedicineVilidityCheck<br />
select * from medic where eDate >= getdate()<br />
select * from medic where eDate < getdate()<br />
select * from medic<br />
UC_P_SellMedicine<br />
select mname from medic where mname like '"+txtSearch.Text+ "%' and eDate >= getdate() and quantity > '0'<br />
select mid,eDate,perUnit from medic where mname='"+name+"'<br />
select quantity  from medic where mid='" + txtMediId.Text + "'<br />
update medic set quantity=" + newQuantity + " where mid='" + txtMediId.Text + "'<br />
select quantity from medic where mid='" + valueId + "'<br />
update medic set quantity ='" + newQuantity + "' where mid='" + valueId + "'<br />
Customer_SignUp<br />
select * from users where username='" + txtUserName.Text + "'<br />
insert into users(userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + password + "'<br />
UC_C_Purchase<br />
select mname from medic where eDate >= getdate() and quantity > '0'<br />
select mname from medic where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity > '0'<br />
select mid,eDate,perUnit from medic where mname='" + name + "'<br />
select quantity  from medic where mid='" + txtMediId.Text + "'<br />
update medic set quantity=" + newQuantity + " where mid='" + txtMediId.Text + "'<br />
select quantity from medic where mid='" + valueId + "'<br />
update medic set quantity ='" + newQuantity + "' where mid='" + valueId + "'<br />


 # Fuctionality of this project
 When the username and password matches the respective user then it will allow to perform all the functionalities. If the data matches with adminstrator then it will open the admin dashboard. Where we can me the total number of admin, pharmacist, customer . Then he have the option to add pharmacist, view all the users, change his profile info.<br />
 If the data matches with pharmacist then it will open pharmacist dashboard. The pharmacist see a graph of expired and valid medicine. The pharmacist perform several oparetions like add medicine, view medicines, modify medicine, check validity, sell medicine.<br />
 If the da matchs with customer then it will open customer dashborad. Where they can buy medicines and update their profile info.

 # Screenshots
 ![image](https://github.com/user-attachments/assets/1bb4e182-7ffe-480d-8559-77a21c1f0fc9)
 ![image](https://github.com/user-attachments/assets/8af5abbc-a370-48a2-9de7-400f119998de)
 ![image](https://github.com/user-attachments/assets/50ff4cd2-132a-4bdf-bf49-7c0b8b9b0edd)
 ![image](https://github.com/user-attachments/assets/5131a844-fcde-473a-a53f-a02e1890d5ed)
 ![image](https://github.com/user-attachments/assets/ec8765ba-66b1-442e-a065-200c10e270b4)
 ![image](https://github.com/user-attachments/assets/4a5e0fb4-3ff6-44c3-8e3a-11f1c5e5b62b)
 ![image](https://github.com/user-attachments/assets/c935f60a-534b-4653-bd67-d19786104c39)
 ![image](https://github.com/user-attachments/assets/2a1385c2-d78d-4011-9e0a-977b5f5fc87a)
 ![image](https://github.com/user-attachments/assets/faa6b8cf-22ec-4d8d-95e6-45187d6311ae)
 ![image](https://github.com/user-attachments/assets/f8092523-4ea3-4b99-b455-6f5c9ee19208)
 ![image](https://github.com/user-attachments/assets/4278bd23-c0ad-4a29-9e49-bbc016dc4a0b)
 ![image](https://github.com/user-attachments/assets/fd3fc616-b44c-4c8c-94ff-0bf2089432fd)
 ![image](https://github.com/user-attachments/assets/fd6a59cd-f284-459c-83b1-40de273a7b76)
 ![image](https://github.com/user-attachments/assets/8f98422d-e19d-43bc-b800-323ecec64d93)
 ![image](https://github.com/user-attachments/assets/44117af2-0c1c-486b-9705-9dee28f65dd8)


# Project Demonstration Video
https://drive.google.com/file/d/15XeC3zVqW768ba_-c4i36xRcxYAzMaNL/view?pli=1






 










  

