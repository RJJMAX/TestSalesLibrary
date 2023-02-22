using SalesLibrary;

CustomersController custCtrl = new CustomersController("localhost", "sqlexpress");






var customers = custCtrl.GetBySalesRange(20000, 50000);

foreach (var cust in customers) {
    Console.WriteLine($"{cust.Id} | {cust.Name} | {cust.City}, {cust.State} | {cust.Sales} | {cust.Active}");

}

//var max = custCtrl.GetById(36);
//if(max is null) {
//    Console.WriteLine("Not found");
//    return;
//}
//max.Name = "MAX Technical Training";

//var success = custCtrl.Update(max);
//if (!success) {
//    Console.WriteLine("Update failed");
//    return;
//}


/* var customers = custCtrl.GetAll();

var newCustomer = new Customer {
    Id = 0, Name = "MAX", City = "Mason", State = "OH", Sales = 1000, Active = true
};

var success = custCtrl.Add(newCustomer);
if (!success) {
    Console.WriteLine("Add Failed");
}

foreach(var customer in customers ) {
    Console.WriteLine(customer.Name);
}
*/

//var success = custCtrl.Delete(36);
//var cust = custCtrl.GetById(36);

//if (custCtrl is null) {
//    Console.WriteLine("Not Found");

//} else {
//    Console.WriteLine($"{cust.Id} | {cust.Name} | { cust.City}, { cust.State} | {cust.Sales} | {cust.Active}");

//}


custCtrl.CloseConnection();