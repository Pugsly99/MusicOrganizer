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
    }
}