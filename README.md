# Pharmacy Managment System Using C#
Here 3 types of Users Adminstrator, Customer,Pharmacist. We use MS Sql to manage all the datas here. Here 2 types of users can add or delete options. If someone delete or upadate data it automatically effect the database. For showing the data we use datagridviwe.  <br />


For Sql script download the file script.sql. Create the tables. <br />
Add Medicine Query <br />
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
# Query for View medicine 
<br />
select * from medic  <br />
select * from medic where mname like '"+txtSearch.Text+"%'  <br />
delete from medic where mid = '"+MedicineID+"'  <br />
 <br />
  <br />
   <br />

   # Functionality of view medicine button
   Here is the database table
    <br />
    
   ![image](https://github.com/user-attachments/assets/3a984fc2-527f-48db-8c85-f9301bb31c83)
   <br />
 <br />
 When you type medicine name in the search box if the medicine is available then it will automatically show in the datagridview. We can also select any row and delete parmaently using the Delete button. It will automatically delete from the database
 <br />
 ![image](https://github.com/user-attachments/assets/74c98688-8ee9-4c43-a3de-70cdb1a921c8)

 <br />
 <br />
 <br />
 # Query for add medicine
 insert into medic (mid, mname, mnumber, mDate, eDate,quantity, perUnit) values('"+ mid + "','"+ mname + "', '"+ mnumber + "', '"+mdate+"', '"+edate+"',"+quantity+","+perunit+")
 <br />
 <br />
 <br />

# Functionality of Add medicine button
 <br />
 Using this we can add new medicine in the database. Here we have to fill all the textbox . We can write the medicine name, medicine ID,  quantity, price per unit. After fill all the boxs if we click on add button it will automatically added to the database.  <br /> 
 <br />
 ![image](https://github.com/user-attachments/assets/db05f31d-be9a-4577-8387-4ed649562c73)





  

