﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enterprise.AdminUI.CustomerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerService.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DoWork", ReplyAction="http://tempuri.org/ICustomerService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DoWork", ReplyAction="http://tempuri.org/ICustomerService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersResponse")]
        Enterprise.Logic.Entities.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersResponse")]
        System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/SearchCustomers", ReplyAction="http://tempuri.org/ICustomerService/SearchCustomersResponse")]
        Enterprise.Logic.Entities.Customer[] SearchCustomers(string searchKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/SearchCustomers", ReplyAction="http://tempuri.org/ICustomerService/SearchCustomersResponse")]
        System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer[]> SearchCustomersAsync(string searchKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        Enterprise.Logic.Entities.Customer AddCustomer(Enterprise.Logic.Entities.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer> AddCustomerAsync(Enterprise.Logic.Entities.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        bool UpdateCustomer(Enterprise.Logic.Entities.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task<bool> UpdateCustomerAsync(Enterprise.Logic.Entities.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomer", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerResponse")]
        Enterprise.Logic.Entities.Customer GetCustomer(System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomer", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerResponse")]
        System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer> GetCustomerAsync(System.Guid customerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : Enterprise.AdminUI.CustomerService.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<Enterprise.AdminUI.CustomerService.ICustomerService>, Enterprise.AdminUI.CustomerService.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public Enterprise.Logic.Entities.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public Enterprise.Logic.Entities.Customer[] SearchCustomers(string searchKey) {
            return base.Channel.SearchCustomers(searchKey);
        }
        
        public System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer[]> SearchCustomersAsync(string searchKey) {
            return base.Channel.SearchCustomersAsync(searchKey);
        }
        
        public Enterprise.Logic.Entities.Customer AddCustomer(Enterprise.Logic.Entities.Customer customer) {
            return base.Channel.AddCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer> AddCustomerAsync(Enterprise.Logic.Entities.Customer customer) {
            return base.Channel.AddCustomerAsync(customer);
        }
        
        public bool UpdateCustomer(Enterprise.Logic.Entities.Customer customer) {
            return base.Channel.UpdateCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateCustomerAsync(Enterprise.Logic.Entities.Customer customer) {
            return base.Channel.UpdateCustomerAsync(customer);
        }
        
        public Enterprise.Logic.Entities.Customer GetCustomer(System.Guid customerId) {
            return base.Channel.GetCustomer(customerId);
        }
        
        public System.Threading.Tasks.Task<Enterprise.Logic.Entities.Customer> GetCustomerAsync(System.Guid customerId) {
            return base.Channel.GetCustomerAsync(customerId);
        }
    }
}
