using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class ArtistTest : IDisposable
    {

      public void Dispose()
      {
        Artist.ClearAll();
      }

      [TestMethod]
      public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
      {
        Artist newArtist = new Artist("Test Artist");
        Assert.AreEqual(typeof(Artist), newArtist.GetType());
      }

      
      [TestMethod]
      public void GetName_ReturnsName_String()
      {
        string name = "Test Artist";
        Artist newArtist = new Artist(name);
        string result = newArtist.Name;
        Assert.AreEqual(name, result);
      }

      [TestMethod]
      public void GetId_ReturnArtistId_int()
      {
        string name = "Test Artist";
        Artist newArtist = new Artist(name);
        int result = newArtist.Id;
        Assert.AreEqual(1, result);
      }

    }
}