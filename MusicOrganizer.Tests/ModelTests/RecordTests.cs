using Microsoft. VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTest : IDisposable
  {
    public void Dispose()
    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreateInstanceOfRecord_Record()
    {
      Record newRecord = new Record("name");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsTheRecordName_String()
    {
      string name = "Record name";
      Record newRecord = new Record(name);
      string result = newRecord.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAll_RecordList()
    {
      string nameOne  = "name1";
      string nameTwo = "name2";
      Record newRecordOne = new Record(nameOne);
      Record newRecordTwo = new Record(nameTwo);
      List<Record> newRecords = new List<Record> { newRecordOne, newRecordTwo};

      List<Record> result = Record.GetAll();

      CollectionAssert.AreEqual(newRecords, result);
    }

    [TestMethod]
    public void GetId_ReturnIdOfRecord_Int()
    {
      string name = "name";
      Record newRecord = new Record(name);

      int result = newRecord.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnRecordById_Record()
    {
      string nameOne  = "name1";
      string nameTwo = "name2";
      Record newRecordOne = new Record(nameOne);
      Record newRecordTwo = new Record(nameTwo);

      Record result = Record.Find(2);

      Assert.AreEqual(newRecordTwo, result);  
    }
  }
}