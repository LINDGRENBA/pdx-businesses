# _PDX Business API_

#### _Restful API project for Epicodus, 08.21.2020_

#### By _**Brittany Lindgren**_

## Description

_This business API is BIPOC and LGBTQIAPK centered and is intended to provide information about the diverse range of businesses that exist in the Portland Oregon area. As stated in this [article published in Forbes](https://www.forbes.com/sites/forbesfinancecouncil/2018/01/22/why-minorities-have-so-much-trouble-accessing-small-business-loans/#2406b24555c4),
>Despite leading a significant portion of the nation's businesses, minority-owned firms are still having a much harder time accessing small business loans than their white counterparts.

The goal of this site is to help work towards equity for business owners by providing a platform where potential customers can connect with and these businesses and support their growth in the Portland community._

## Specifications

| Behavior | Input | Output | Met? (Y/N) |
| -------- | :---: | -----: | ---------: |
|          |       |        |            |

## Stretch Goals

| Behavior | Input | Output | Met? (Y/N) |
| -------- | :---: | -----: | ---------: |


## User Stories

* Users should be able to search for all businesses in the database.
* Users should be able to search for a specific business by id.
* Users should be able to add businesses to the database, update a businesses information or delete a business


## Setup/Installation Requirements

There are multiple ways to query the API. To search by ...  
Use an ampersand(&) to separate parameters.
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
<!-- - ASP.NET Core Identity -->
<!-- - ASP.NET Core MVC -->
- .NET Core 2.2
- MySQL & MySQL Workbench
- C#
<!-- - Razor -->
- Visual Studio Code
- Git Version Control
- GitHub

### License

_This site is licensed under the MIT license._

Copyright (c) 2020 _{Brittany Lindgren}_


<!-- If using Postman

search for all businesses: 
  select the GET action in the dropdown
  enter the following route into url box : http://localhost:5000/api/businesses 

search for a specific business by id:
  select the GET action in the dropdown
  enter the following route into url box and add the id at the end of the route : http://localhost:5000/api/businesses/1

add a business: POST 
  select 'Body' directly underneath url box
  change radio button 'none' to 'raw'
  change dropdown from 'Text' to 'JSON'
  enter new business object into the body section (directly under the raw and JSON section)
  Example Object
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

  To Edit an existing object:
    select the PUT action in the dropdown
    enter the following route into url box and add the id of the object you want to edit at the end of the route : http://localhost:5000/api/businesses/1
    update the existing business object into the body section (directly under the raw and JSON section)
    Example Object
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

  Delete a specific business by id:
    select the DELETE action in the dropdown
    enter the following route into url box and add the id at the end of the route : http://localhost:5000/api/businesses/1 -->


