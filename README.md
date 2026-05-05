**In this project, I prepared an automation that will allow veterinary clinics to carry out their procedures.  
Before running the automation, please execute the provided  database script file located in the source folder to set up the necessary database structure. (.sql)  
As this is my first project, I appreciate your understanding regarding any potential limitations. Feedback is always welcome!**


<img width="945" height="142" alt="image" src="https://github.com/user-attachments/assets/358e9e2a-42ed-4d5b-9a21-9e7823aaa8e1" />


**First, I wrote the database and designed it accordingly with Windows Forms. I used the '.' expression, which takes the default SQL connection on the computer, so that my database would also work on other computers. Afterwards, I created a class to avoid dealing with connecting to the database each time and defined this connection there.**


<img width="945" height="575" alt="image" src="https://github.com/user-attachments/assets/6645cc9d-a70c-4691-a3ee-977aa1f2bd9a" />
<img width="945" height="383" alt="image" src="https://github.com/user-attachments/assets/bfea8df0-fb1b-4b2c-9ac6-fec28986f75b" />


**Here, I designed it with WinForms for user login and connected it to my database. I had already assigned a username and password to my database. They are 'Veteriner' and '1234'**


<img width="945" height="570" alt="image" src="https://github.com/user-attachments/assets/3152a048-a52d-484d-b922-3792abdbfedc" />
<img width="603" height="196" alt="image" src="https://github.com/user-attachments/assets/da3cbfce-1a12-4625-a1e6-fa188dba298a" />


**I designed this form to be the main menu; it displays a welcome message based on the entered username and provides access to forms for various operations through the buttons on the screen.**


<img width="945" height="650" alt="image" src="https://github.com/user-attachments/assets/2662a742-4012-408f-a329-2465abae4589" />
<img width="945" height="473" alt="image" src="https://github.com/user-attachments/assets/5fcbf03d-fdce-4197-9cc5-12f9062c06fc" />


**In this form, we add owner and animal records to the database; I provided this using C# with SQL queries. A new animal record can already be added on top of an existing owner record, and for record deletion, both the owner and animal records can be deleted, while at the same time we can also allow only the animal record to be deleted.**


<img width="945" height="583" alt="image" src="https://github.com/user-attachments/assets/d06b4a98-63d8-4f4f-af35-75dca428eb5f" />
<img width="945" height="372" alt="image" src="https://github.com/user-attachments/assets/5538cbcf-0b2d-4d1d-8aa1-7e2c347273d2" />


**In this form, we register our products. If there is an error in our product information, we can select the product from the DataGridView and then update its data.**


<img width="945" height="568" alt="image" src="https://github.com/user-attachments/assets/98608d2e-7c9c-4011-9821-e1308b1b4856" />
<img width="945" height="524" alt="image" src="https://github.com/user-attachments/assets/7e3de375-feb2-4337-88e9-b20ce819af68" />


**This form ensures that appointments are made for the procedures to be carried out. We can reschedule the appointment to an earlier or later time afterwards.**


<img width="945" height="422" alt="image" src="https://github.com/user-attachments/assets/1b196be9-9552-436b-a657-32677374277d" />


**In this form, product sales transactions and payments to be collected for the transactions performed are recorded. With the earnings calculation on the right side of the screen, the daily, monthly, and yearly sales of the business are calculated.**



**In my project, I used components like 'AddWithValue', which allows protection against attacks such as 'SQL injection'.**
