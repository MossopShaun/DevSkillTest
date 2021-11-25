
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace BookingGatewayService.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class StructureTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void RepositoryStructureTest()
        {
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            ParameterInfo parameter;
            int parametersCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            PropertyInfo property;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("Qm9va2luZ0dhdGV3YXlSZXBvc2l0b3J5LCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("SURCUmVwb3NpdG9yeQ==") /*"IDBRepository"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository");
            Assert.IsTrue(type.IsAbstract, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository is not abstract class");
            Assert.IsTrue(type.IsInterface, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository is not interface");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("U2F2ZUJvb2tpbmc=") /*"SaveBooking"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("dHJhbnNhY3Rpb24=") /*"transaction"*/  && x.ParameterType.FullName == "BookingGatewayRepository.Model.TransactionData");
            Assert.IsNotNull(parameter, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) parameter transaction does not exists or does not have type BookingGatewayRepository.Model.TransactionData");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("R2V0U3RhdHVzZXM=") /*"GetStatuses"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("BookingGatewayRepository.Model.TransactionStatus[]", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("dW5pcXVlVHJhbnNhY3Rpb25SZWZz") /*"uniqueTransactionRefs"*/  && x.ParameterType.FullName == "System.String[]");
            Assert.IsNotNull(parameter, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) parameter uniqueTransactionRefs does not exists or does not have type System.String[]");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("VHJhbnNhY3Rpb25EYXRh") /*"TransactionData"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData");
            Assert.IsTrue(type.IsClass, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData is not class");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData() does not exists");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("QW1vdW50") /*"Amount"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.Decimal Amount does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0Ftb3VudA==") /*"get_Amount"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Decimal", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0Ftb3VudA==") /*"get_Amount"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Decimal", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.Decimal", propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.Decimal Amount  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("VHJhbnNhY3Rpb25UaXRsZQ==") /*"TransactionTitle"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String TransactionTitle does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1RyYW5zYWN0aW9uVGl0bGU=") /*"get_TransactionTitle"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1RyYW5zYWN0aW9uVGl0bGU=") /*"get_TransactionTitle"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.String", propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String TransactionTitle  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("U291cmNlQWNjb3VudE5v") /*"SourceAccountNo"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String SourceAccountNo does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1NvdXJjZUFjY291bnRObw==") /*"get_SourceAccountNo"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1NvdXJjZUFjY291bnRObw==") /*"get_SourceAccountNo"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.String", propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String SourceAccountNo  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("RGVzdEFjY291bnRObw==") /*"DestAccountNo"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String DestAccountNo does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0Rlc3RBY2NvdW50Tm8=") /*"get_DestAccountNo"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0Rlc3RBY2NvdW50Tm8=") /*"get_DestAccountNo"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.String", propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String DestAccountNo  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("VW5pcXVlUmVm") /*"UniqueRef"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String UniqueRef does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.String", propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String UniqueRef  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("VHJhbnNhY3Rpb25TdGF0dXM=") /*"TransactionStatus"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus");
            Assert.IsTrue(type.IsClass, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus is not class");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus() does not exists");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("VW5pcXVlUmVm") /*"UniqueRef"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String UniqueRef does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.String", propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String UniqueRef  type has changed");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("U3RhdHVz") /*"Status"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String Status does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1N0YXR1cw==") /*"get_Status"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X1N0YXR1cw==") /*"get_Status"*/ ); Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() is not public");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.String", methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("System.String", propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String Status  type has changed");


        }


        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void ServiceStructureTest()
        {
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            ParameterInfo parameter;
            int parametersCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            PropertyInfo property;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("Qm9va2luZ0dhdGV3YXlTZXJ2aWNlLCBWZXJzaW9uPTAuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("Qm9va2luZ0dhdGV3YXlGYWN0b3J5") /*"BookingGatewayFactory"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory");
            Assert.IsTrue(type.IsClass, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory is not class");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Q3JlYXRlR2F0ZXdheQ==") /*"CreateGateway"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateGateway(IDBRepository repository) does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateGateway(IDBRepository repository) is not public");
            Assert.IsTrue(method.IsStatic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateGateway(IDBRepository repository) is not static");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("BookingGatewayService.IBookingGateway", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateGateway(IDBRepository repository) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateGateway(IDBRepository repository) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("cmVwb3NpdG9yeQ==") /*"repository"*/  && x.ParameterType.FullName == "BookingGatewayRepository.IDBRepository");
            Assert.IsNotNull(parameter, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateGateway(IDBRepository repository) parameter repository does not exists or does not have type BookingGatewayRepository.IDBRepository");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Q3JlYXRlT2JqZWN0") /*"CreateObject"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateObject() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateObject() is not public");
            Assert.IsTrue(method.IsStatic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateObject() is not static");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Object", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.CreateObject() return type has changed");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("TmV3T2JqZWN0") /*"NewObject"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.NewObject() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.NewObject() is not public");
            Assert.IsTrue(method.IsStatic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.NewObject() is not static");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Object", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory.NewObject() return type has changed");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.BookingGatewayFactory() does not exists");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("SUJvb2tpbmdHYXRld2F5") /*"IBookingGateway"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway");
            Assert.IsTrue(type.IsAbstract, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway is not abstract class");
            Assert.IsTrue(type.IsInterface, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway is not interface");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway is not public class");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("U3RhcnRCb29raW5n") /*"StartBooking"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.StartBooking() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.StartBooking() is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.StartBooking() is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.StartBooking() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.StartBooking() return type has changed");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("RW5kQm9va2luZw==") /*"EndBooking"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.EndBooking() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.EndBooking() is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.EndBooking() is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.EndBooking() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.EndBooking() return type has changed");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("Qm9va2luZw==") /*"Booking"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Void", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(5, parametersCount, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("dW5pcXVlUmVmZXJlbmNl") /*"uniqueReference"*/  && x.ParameterType.FullName == "System.String");
            Assert.IsNotNull(parameter, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameter uniqueReference does not exists or does not have type System.String");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(5, parametersCount, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("YW1vdW50") /*"amount"*/  && x.ParameterType.FullName == "System.Decimal");
            Assert.IsNotNull(parameter, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameter amount does not exists or does not have type System.Decimal");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(5, parametersCount, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("dHJhbnNhY3RvblRpdGxl") /*"transactonTitle"*/  && x.ParameterType.FullName == "System.String");
            Assert.IsNotNull(parameter, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameter transactonTitle does not exists or does not have type System.String");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(5, parametersCount, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("c3JjQWNjb3VudE5v") /*"srcAccountNo"*/  && x.ParameterType.FullName == "System.String");
            Assert.IsNotNull(parameter, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameter srcAccountNo does not exists or does not have type System.String");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(5, parametersCount, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("ZGVzdEFjY291bnRObw==") /*"destAccountNo"*/  && x.ParameterType.FullName == "System.String");
            Assert.IsNotNull(parameter, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.Booking(String uniqueReferenceDecimal amountString transactonTitleString srcAccountNoString destAccountNo) parameter destAccountNo does not exists or does not have type System.String");
            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x => x.Name == Decode("R2V0Qm9va2luZ1N0YXR1c2Vz") /*"GetBookingStatuses"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.GetBookingStatuses(IList`1 uniqueTransactionRefs) does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.GetBookingStatuses(IList`1 uniqueTransactionRefs) is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.GetBookingStatuses(IList`1 uniqueTransactionRefs) is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.GetBookingStatuses(IList`1 uniqueTransactionRefs) is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("System.Collections.Generic.IList`1[[BookingGatewayRepository.Model.TransactionStatus, BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.GetBookingStatuses(IList`1 uniqueTransactionRefs) return type has changed");
            parametersCount = method.GetParameters().Length;
            Assert.AreEqual(1, parametersCount, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.GetBookingStatuses(IList`1 uniqueTransactionRefs) parameters count has changed");
            parameter = method.GetParameters().FirstOrDefault(x => x.Name == Decode("dW5pcXVlVHJhbnNhY3Rpb25SZWZz") /*"uniqueTransactionRefs"*/  && x.ParameterType.IsGenericType && x.ParameterType.FullName.StartsWith("System.Collections.Generic.IList`1[[System.String"));
            Assert.IsNotNull(parameter, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.GetBookingStatuses(IList`1 uniqueTransactionRefs) parameter uniqueTransactionRefs does not exists or does not have type System.Collections.Generic.IList`1[[System.String, System.Private.CoreLib, Version=5.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]");
            property = type.GetProperties().Union(type.GetProperties().Where(x => type.GetInterfaces().SelectMany(y => y.GetProperties().Select(s => s.Name)).Any(y => y == x.Name))).FirstOrDefault(x => x.Name == Decode("REJSZXBvc2l0b3J5") /*"DBRepository"*/ );
            Assert.IsNotNull(property, "property: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.IDBRepository DBRepository does not exists");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0RCUmVwb3NpdG9yeQ==") /*"get_DBRepository"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("BookingGatewayRepository.IDBRepository", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() return type has changed");
            method = type.GetMethods().FirstOrDefault(x => x.Name == Decode("Z2V0X0RCUmVwb3NpdG9yeQ==") /*"get_DBRepository"*/ ); Assert.IsNotNull(method, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() does not exists");
            Assert.IsTrue(method.IsPublic, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() is not public");
            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() is not abstract");
            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() is not virtual");
            methodReturnType = method.ReturnType;
            Assert.AreEqual("BookingGatewayRepository.IDBRepository", methodReturnType.FullName, "method: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.get_DBRepository() return type has changed");
            propertyReturnType = property.PropertyType;
            Assert.AreEqual("BookingGatewayRepository.IDBRepository", propertyReturnType.FullName, "property: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.IBookingGateway.IDBRepository DBRepository  type has changed");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("Qm9va2luZ0luUHJvZ3Jlc3NFeGNlcHRpb24=") /*"BookingInProgressException"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.BookingInProgressException");
            Assert.IsTrue(type.IsClass, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.BookingInProgressException is not class");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.BookingInProgressException is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.BookingInProgressException() does not exists");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("Tm9TdGFydEJvb2tpbmdFeGNlcHRpb24=") /*"NoStartBookingException"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.NoStartBookingException");
            Assert.IsTrue(type.IsClass, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.NoStartBookingException is not class");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.NoStartBookingException is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.NoStartBookingException() does not exists");

            type = assembly.GetTypes().FirstOrDefault(x => x.Name == Decode("UmVhZE9wZXJhdGlvbkluUHJvZ3Jlc3NFeGNlcHRpb24=") /*"ReadOperationInProgressException"*/ );
            Assert.IsNotNull(type, "Missing assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.ReadOperationInProgressException");
            Assert.IsTrue(type.IsClass, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.ReadOperationInProgressException is not class");
            Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.ReadOperationInProgressException is not public class");
            constructorParameterNameTypeDictionary = new List<string>();
            constructor = type.GetConstructors().FirstOrDefault(x => x.GetParameters().Select(y => y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
            Assert.IsNotNull(constructor, "constructor: BookingGatewayService, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayService.Exceptions.ReadOperationInProgressException() does not exists");
        }


        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
