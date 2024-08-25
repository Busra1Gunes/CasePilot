// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;
using System.Net;
Console.WriteLine("Hello, World!");

StockManager stockManager = new(new EfStockDal());
stockManager.GetById(1);

