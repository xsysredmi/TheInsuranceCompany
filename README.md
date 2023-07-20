# .NET WebAPI Code Challenge
Great to see that you are interested in working with us! We would really like to expand this group of developers. At TheInsuranceCompany we are great at selling, you guessed it, insurances! Offering Car, Liabillity and Travel insurances. Our +- 60 WebAPI's make sure that the frontend (and the customer) are presented with exactly the right information. This way we try to minimalize the effort the frontend has to make. 

## System Requirements
- Visual Studio 2022
- GIT

## The currect product
The current product is a WebAPI with two operations. 

### GetInsurances
The GetInsurances operation returns all the names of the insurance that TheInsuranceCompany offers.

### AddInsurance
The AddInsurance operation allows the employee to add an insurance to the product suite. 

## The architecture
![image](https://github.com/GJBos/TheInsuranceCompany/assets/12369592/c7302c61-ee51-4ad3-b271-11222faf059b)

## The Challenge - New WebAPI Operation GetDutchTravelInsurances
As a developer for TheInsuranceCompany, we would like you to implemented a new WebAPI operation named GetDutchTravelInsurances that returns all details of every TravelInsurance that covers the Netherlands (NL). When finished add a pullrequest to the project with your changes. The operation contract should look as follows:

Request:
Emtpy

Response:
A list of Insurances where each insurance has the following properties:
- Name
- Description
- InsurancePremium
- InsuredAmount

The build is currently failing. We have already modified an Interface to get you started. There is a static class DatabaseStub that mimics a database containing all the data that the operation GetDutchTravelInsurances need to return. You don't need to change this class.
