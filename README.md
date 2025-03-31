# Simple-Accountbook 
Description: An account book application written in C#
## Download:
1. Click below!<br>
https://github.com/chs415009/simple-accountbook.git <br>

2. Open with Visual Studio by executing the "AccoutingAPP.sln" file.<br>


## Instructions:
__This project allows you to record all your expenses and income with several functions.__ <br>
~ The detailed procedures are shown below. ~ <br>
<br>

### --- Form 1 ----------
* __The first form is for sign in/sign up.__

__1.__ <br>
<img src="./bin/1.png" width="500">

* The initial input of the username and password serves as the registration process. The system will check if this account exists.<br>
If it doesn't, a prompt will appear asking whether to proceed with registration.<br>
<br>

__2.__ <br>
<div style="display: flex;">
  <img src="./bin/1 no account.png" width="100">
  <img src="./bin/1 no password.png" width="100">
  <img src="./bin/1 no account password .png" width="100">
  <img src="./bin/1 X password.png" width="100">
</div>

* The system will automatically check if there are blank fields or incorrect passwords, as shown in the four images above. <br>
<br>

### --- Form 2 ----------
* __The second form is the main page.__ <br>
From left to right, the three buttons are: 離開-Exit, 新增-Add, 檢視-View.

__1.__ <br>
<img src="./bin/2.png" width="500">

* The "離開" button is for saving and exiting. When you click it, a confirmation prompt will appear. <br> 
* The "新增" and "檢視" buttons will take you to "Form3" and "Form4" respectively. <br>
(Form3 and Form4 are explained below)<br>
<br>

__2.__ <br>
<div style="display: flex;">
  <img src="./bin/2 save.png" width="500">
  <img src="./bin/2 X exit.png " width="500"> 
</div>

* If you click "Yes", it will successfully save and quit. <br>
* If you click "No", it won't save and quit. Instead, it will display all records for your review.<br>
<br>

### --- Form 3 ----------
* __The third form is for adding new records.__

__1.__ <br>
<img src="./bin/3.png" width="500">

* First, you can select the date at the top of the page.<br>
** _You will need to select from year to day sequentially to correctly show the 29th, 30th, 31st. <br>
Otherwise, there may be errors with the date_. **<br>
<br>

__2.__ <br>
<img src="./bin/3 add.png" width="500">

* After you successfully add a new record, a message box will display the result.<br>
<br>

__3.__ <br>
<img src="./bin/3 add list.png" width="500">

* A second message box will appear after the first one, as shown above. <br>
It displays all records added before leaving Form3.<br>
<br>

__4.__ <br>
<img src="./bin/3 X money.png" width="500">

* As shown in the image above, if the category of the record belongs to "income" and the money value is negative, <br>
  it will show "金額輸入有誤!", which means wrong format for the money.
* However, if you input a positive number while selecting categories belonging to "expense", it will automatically add a "-" sign.<br>
<br>

### --- Form 4 ----------
* __The fourth form is for viewing and deleting records.__

__1.__ <br>
<img src="./bin/4.png" width="500">

* The list on the left side shows all records with information, including category, description, amount, and date.<br>
<br>

__2.__ <br>
<div style="display: flex;">
  <img src="./bin/4 find result.png" width="630">
  <img src="./bin/4 find list.png" width="100">
</div>
  
* The records on the right side can be filtered by the category you select in the "查詢" textbox. <br>
  "-" Represents the hierarchy level of each category group. <br>
  (Example: Selecting "交通" will show results including "汽油", "公車", "火車", "捷運", "其他(交")<br>
<br>

__3.__ <br>
<div style="display: flex;">
  <img src="./bin/4 delete.png" width="400">
  <img src="./bin/4 X delete.png" width="400">  
</div>

* To delete a record, select it on the right side and then click the "刪除" button. <br>
  ** _You can only delete one record at a time._ **
* If you click the button without selecting any records, a notification message box will appear. <br>

## Let's begin!
