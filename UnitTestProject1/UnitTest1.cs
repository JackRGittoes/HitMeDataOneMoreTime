using HitMeDataOneMoreTime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private ISongRepository _repository;
        private IList<Song> _data;

        [TestInitialize]
        public void TestInitialize()
        {
            _data = new List<Song>();
            _repository = new SongRepository(_data);
        }

        #region LongestSong Unit Tests
        [TestMethod]
        public void LongestSong_Returns_Longest_Song()
        {
            //Arrange

            _data.Add(new Song
            {
                artist = "Bob Dylan",
                time = new TimeSpan(0, 3, 1),
                track = "Don't think twice its alright",
                dateentered = DateTime.Now,
                datepeaked = DateTime.Now,
                year = 2000

            });

            _data.Add(new Song
            {
                artist = "My Morning Jacket",
                time = new TimeSpan(0, 5, 10),
                track = "Golden",
                dateentered = DateTime.Now,
                datepeaked = DateTime.Now,
                year = 2000

            });
            _data.Add(new Song
            {
                artist = "Kanye West",
                time = new TimeSpan(0, 1, 15),
                track = "Yikes",
                dateentered = DateTime.Now,
                datepeaked = DateTime.Now,
                year = 2000

            });

            //Act
            var result = _repository.LongestSong();

            //Assert
            Assert.AreEqual("Golden", result);
        }

        [TestMethod]
        public void LongestSong_Returns_Null_When_There_Are_No_Songs()
        {
            //Arrange

            //Act
            var result = _repository.LongestSong();

            //Assert
            Assert.IsNull(result);
        }
        #endregion

        #region MostSingles Unit Tests
        [TestMethod]
        public void MostSingles_Returns_Artist_With_The_Most_Singles()
        {
            //Arrange
            _data.Add(new Song
            {
                artist = "Bob Dylan",
                time = new TimeSpan(0, 3, 1),
                track = "Don't think twice its alright",
                dateentered = DateTime.Now,
                datepeaked = DateTime.Now,
                year = 2000

            });

            _data.Add(new Song
            {
                artist = "Kanye West",
                time = new TimeSpan(0, 5, 10),
                track = "I love it",
                dateentered = DateTime.Now,
                datepeaked = DateTime.Now,
                year = 2000

            });
            _data.Add(new Song
            {
                artist = "Kanye West",
                time = new TimeSpan(0, 1, 15),
                track = "Yikes",
                dateentered = DateTime.Now,
                datepeaked = DateTime.Now,
                year = 2000

            });

            //Act
            var result = _repository.MostSingles();

            //Assert
            Assert.AreEqual("Kanye West", result);
        }

        [TestMethod]
        public void MostSingles_Returns_Null_When_There_Are_No_Artists()
        {
            //Arrange

            //Act
            var result = _repository.MostSingles();

            //Assert
            Assert.IsNull(result);
        }

        #endregion

        #region HowManyHits Unit Tests

        [TestMethod]
        public void HowManyHits_Returns_1_Hit_Before_2000()
        {
            //Arrange
            var artist = "Bob Dylan";
            _data.Add(new Song
            {
                artist = "Bob Dylan",
                time = new TimeSpan(0, 3, 1),
                track = "Don't think twice its alright",
                dateentered = new DateTime(1999, 12, 25),
                datepeaked = new DateTime(1999, 12, 25),
                year = 2000

            });

            _data.Add(new Song
            {
                artist = "Bob Dylan",
                time = new TimeSpan(0, 5, 10),
                track = "Knockin' On Heavens Door",
                dateentered = new DateTime(2000, 1, 12),
                datepeaked = new DateTime (2000, 1, 12),
                year = 2000

            });

            _data.Add(new Song
            {
                artist = "Kanye West",
                time = new TimeSpan(0, 5, 10),
                track = "Bound 2",
                dateentered = new DateTime(2000, 2, 12),
                datepeaked = new DateTime(2000, 2, 12),
                year = 2000

            });
            //Act
            var result = _repository.HowManyHits(artist);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void HowManyHits_Returns_0_When_There_Are_No_Hits_Before_2000()
        {
            //Arrange
            var artist = "Bob Dylan";

            _data.Add(new Song
            {
                artist = "Bob Dylan",
                time = new TimeSpan(0, 5, 10),
                track = "Knockin' On Heavens Door",
                dateentered = new DateTime(2000, 1, 12),
                datepeaked = new DateTime(2000, 1, 12),
                year = 2000

            });

            _data.Add(new Song
            {
                artist = "Kanye West",
                time = new TimeSpan(0, 5, 10),
                track = "Bound 2",
                dateentered = new DateTime(2000, 2, 12),
                datepeaked = new DateTime(2000, 2, 12),
                year = 2000

            });

            //Act
            var result = _repository.HowManyHits(artist);

            //Assert
            Assert.AreEqual(0, result);
        }
        #endregion
    }
}
