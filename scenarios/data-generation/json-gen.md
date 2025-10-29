## Data Generation with JSON
```
Generate a sample JSON array of 10 rows of sample data. The data should include the following keys: 
- employee ID (unique and random in the range 1 to 100),
- department name (randomly assigned to one of the following departments: HR, Engineering, Sales),
- first name,
- last name,
- hourly rate ($25.00 to $75.00, standard deviation of $7.65)
Use international naming conventions for the names.
```

## Consuming JSON Data in Java
```
Assuming the data you provided is consumable over http://localhost:6543/employees, how would I consume this JSON data using Java within package 'hr'? 
- The design must include a service contract (an EmployeeService interface) and a concrete implementation (EmployeeServiceImpl) with each type in its own file. 
- Make the implementation responsible for performing the HTTP request, parsing JSON, mapping to Employee objects, and handling errors. 
- The design should be dependency-injection friendly (constructor injection), unit-testable (allow the HTTP client to be mocked), and include expectations for timeouts, retries, logging, and JSON schema validation.
- The result should produce a java.util.List<Employee> and adhere to SOLID design principles. 
```
