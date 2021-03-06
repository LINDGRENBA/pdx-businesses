# _PDX Business API_

#### _Restful API project for Epicodus, 08.21.2020_

#### By _**Brittany Lindgren**_

## Description

*This business API is BIPOC and LGBTQIAPK centered and is intended to provide information about the diverse range of businesses and amazing business owners that exist in the Portland Oregon area. As stated in this [article published in Forbes](https://www.forbes.com/sites/forbesfinancecouncil/2018/01/22/why-minorities-have-so-much-trouble-accessing-small-business-loans/#2406b24555c4),*
>Despite leading a significant portion of the nation's businesses, minority-owned firms are still having a much harder time accessing small business loans than their white counterparts. 

*The goal of this site is to help work towards equity for business owners by providing a platform where potential customers can connect with and these businesses and support their growth in the Portland community. Much of the information used to seed the database came from the following websites: [Streetroots](https://www.streetroots.org/news/2020/05/16/photo-story-community-resilience-carries-native-owned-businesses-through-pandemic) and [Mercatus](https://mercatuspdx.com/directory/black-owned-businesses/#!directory/ord=rnd).*


## User Stories

* Users should be able to search for all businesses in the database.
* Users should be able to search for a specific business by id.
* Users should be able to add businesses to the database, update a businesses information or delete a business  


## Stretch Goals

* Add feature to search by parameters
* Implementing JWT authentication  


## Setup/Installation Requirements

* Clone the repository from the GitHub website.
* Open the project in Visual Studio Code or a code editor of your choosing.
* Once the project is open, select **Terminal** from the toolbar at the top of the window - a terminal should open at the bottom of the window.
* Place your cursor in the terminal and navigate into the project directory by typing the command `cd PdxBusiness` and hitting **enter**. 
* Once you have navigated into the project directory, type the following commands into the terminal one at a time, hitting **enter** after each command and waiting for the commands to finish running.
  1. `dotnet restore`
  2. `dotnet clean`
  3. `dotnet build`
* If these three commands complete successfully, you are now able to enter the command `dotnet run` and then hit **enter**. This will start a server for the project. You are now ready to query the API.
* When you are finished, to close the server, select `Ctrl + C` on your keyboard for Windows or `Cmd + C` on a Mac.

## Querying the API

There are multiple ways to query the API. The API stores data for Businesses as well as Owners. The examples below are searces for businesses, but to search for business owners instead, simply change `businesses` to `owners` in the Url. For example, you can change `http://localhost:5000/api/businesses` to `http://localhost:5000/api/owners`. The examples below also provide instructions for querying this API through [Postman](https://www.postman.com/). If you are incorporating this API into your own project, you can disregard the instructions to "Select the GET action in the dropdown" or to change radio buttons or dropdowns and simply incorporate the Urls as listed in the examples.

* To search for all businesses/owners: 
  1. Select the GET action in the dropdown
  2. Enter the following route into url box : `http://localhost:5000/api/businesses`

* To search for a specific business/owner by id:
  1. Select the GET action in the dropdown
  2. Enter the following route into url box and add the id at the end of the route : `http://localhost:5000/api/businesses/1`

* Search with parameters to limit the number of pages or number of search results you receive. Remember, in the examples below, you can exchange the word 'businesses' with 'owners' to search the list of owners instead:
  1. Select the GET action in the dropdown
  2. Enter a route url and add a query with the following format `/pages?PageNumber=#&PageSize=#` changing the 3 to your desired parameters
  For example, you could enter the following route into the url box: `http://localhost:5000/api/businesses/pages?PageNumber=1&PageSize=5` - this will return the first page, with up to 5 search results on that page. 
  3. You can adjust the query in a couple of ways
    * To change the page number that you receive, you can update the PageNumber
      ex: `http://localhost:5000/api/businesses/pages?PageNumber=100&PageSize=5` - this will return the one-hundreth page, with up to 5 items on that page.
    * To change the number of responses per page, you can update the PageSize 
      ex: `http://localhost:5000/api/businesses/pages?PageNumber=1&PageSize=30` - this will return the first page, with up to 30 items on that page.
**Note: If there are fewer items in the database than you are requesting (for example, you query PageSize=30 to see 30 results on the page, but there are only 10 items in the database), you will see the smaller number of items returned.

* To add a business/owner: POST 
  1. Select 'Body' directly underneath url box
  2. Change radio button 'none' to 'raw'
  3. Change dropdown from 'Text' to 'JSON'
  4. Enter new business object into the body section (directly under the raw and JSON section)
  5. Enter the route into the postman Url box : `http://localhost:5000/api/businesses`
  Example Business Object:
  ```
  {
    "Name": "Bahia Honey Beauty and Well-being",
    "Owner": "Bahia Overton",
    "Address": "not-available",
    "PhoneNumber": "(503) 395-7090",
    "Description": "Skincare for all skin types, all natural.",
    "Url": "https://bahiahoney.com/"
  }
  ```
  Example Owner Object:
  ```
  {
    "ownerId": 4,
    "name": "Val Solorzano",
    "business": "Chick of All Trades, LLC",
    "bio": "Val Solorzano started her business in 2006 and focused initially on providing traffic control services. Her business has since grown and expanded and now has a hand in a variety of projects around Portland."
  }
  ```
  4. Click the **Send** button to the right of the Url box

* To Edit an existing object:
  1. Select the PUT action in the dropdown
  2. Enter the route into the postman url box and add the id of the object you want to edit at the end of the route : `http://localhost:5000/api/businesses/1`
  3. Update the existing business object in the body section (directly under the raw and JSON section)
  Example Business Object:
  ```
  {
    "Name": "Bahia Honey Beauty and Well-being",
    "Owner": "Bahia Overton",
    "Address": "online only",
    "PhoneNumber": "(503) 395-7090",
    "Description": "Skincare for all skin types, all natural.",
    "Url": "https://bahiahoney.com/"
  }
  ```
  Example Owner Object:
  ```
  {
    "ownerId": 4,
    "name": "Val Solorzano",
    "business": "C.O.A.T.",
    "bio": "Val Solorzano started her business in 2006 and focused initially on providing traffic control services. Her business has since grown and expanded and now has a hand in a variety of projects around Portland."
  }
  ```
  4. Click the **Send** button to the right of the Url box

* To delete a specific business by id:
  1. Select the DELETE action in the dropdown
  2. Enter the following route into url box and add the id at the end of the route : `http://localhost:5000/api/businesses/1`


<!-- Use an ampersand(&) to separate parameters. -->
<!-- To search by page and/or to limit the number of results per page, add `pages?` after `places/`, then specity the pageNumber (which page you would like to see) and pageSize (how many results you would like per page. Here is an example query:  `http://localhost:5000/api/places/pages?pageNumber=2&pageSize=8`. If pageSize is not specified, the default number of results per page is 10. -->

## Known Bugs

| Bug : Message | Situation | Resolved (Y/N) | How was the issue resolved? |
| ------------- | --------- | -------------- | --------------------------- |
|               |           |                |                             |

## Support and contact details

_Please feel free to contact the author through GitHub (LINDGRENBA) with any feedback, questions or concerns._

## Technologies Used

- Entity Framework Core
- .NET Core CLI
- .NET Core 2.2
- MySQL & MySQL Workbench
- C#
- Visual Studio Code
- Git Version Control
- GitHub

### License

_This site is licensed under the MIT license._

Copyright (c) 2020 _{Brittany Lindgren}_
