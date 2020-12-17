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

    //[TestMethod]
    //public void 
  }
}