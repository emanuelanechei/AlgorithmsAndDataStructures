﻿/* 
 * Copyright (c) 2019 (PiJei) 
 * 
 * This file is part of CSFundamentalAlgorithms project.
 *
 * CSFundamentalAlgorithms is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * CSFundamentalAlgorithms is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with CSFundamentalAlgorithms.  If not, see <http://www.gnu.org/licenses/>.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSFundamentalAlgorithms.SearchingAlgorithms.StringSearch;
using System.Collections.Generic;
using System.Linq;

namespace CSFundamentalAlgorithmsTests.SearchingAlgorithmsTests.StringSearchTests
{
    [TestClass]
    public class KMPSearchTests
    {
        [TestMethod]
        public void KMPSearch_Search_Test()
        {
            Assert.AreEqual(1, KMPSearch.Search("abcd", "bc")[0]);
            Assert.AreEqual(2, KMPSearch.Search("abcd", "cd")[0]);
            Assert.AreEqual(12, KMPSearch.Search("aaaaaakcdkaaaabcd", "aab")[0]);
            Assert.IsTrue(KMPSearch.Search("abcaab", "a").SequenceEqual(new List<int> { 0, 3, 4 }));
            Assert.IsTrue(KMPSearch.Search("abcaab", "abc").SequenceEqual(new List<int> { 0 }));
            Assert.AreEqual(0, KMPSearch.Search("aaabbbdaacbb", "kjh").Count);
        }


        [TestMethod]
        public void KMPSearch_GetLongestProperPrefixWhichIsAlsoSuffix_Test1()
        {
            List<int> longestProperPrefixes1 = KMPSearch.GetLongestProperPrefixWhichIsAlsoSuffix("aaaabcbaab");
            Assert.AreEqual(0, longestProperPrefixes1[0]);
            Assert.AreEqual(1, longestProperPrefixes1[1]);
            Assert.AreEqual(2, longestProperPrefixes1[2]);
            Assert.AreEqual(3, longestProperPrefixes1[3]);
            Assert.AreEqual(0, longestProperPrefixes1[4]);
            Assert.AreEqual(0, longestProperPrefixes1[5]);
            Assert.AreEqual(0, longestProperPrefixes1[6]);
            Assert.AreEqual(1, longestProperPrefixes1[7]);
            Assert.AreEqual(2, longestProperPrefixes1[8]);
            Assert.AreEqual(0, longestProperPrefixes1[9]);
        }

        [TestMethod]
        public void KMPSearch_GetLongestProperPrefixWhichIsAlsoSuffix_Test2()
        {
            List<int> longestProperPrefixes1 = KMPSearch.GetLongestProperPrefixWhichIsAlsoSuffix("abcdef");
            Assert.AreEqual(0, longestProperPrefixes1[0]);
            Assert.AreEqual(0, longestProperPrefixes1[1]);
            Assert.AreEqual(0, longestProperPrefixes1[2]);
            Assert.AreEqual(0, longestProperPrefixes1[3]);
            Assert.AreEqual(0, longestProperPrefixes1[4]);
            Assert.AreEqual(0, longestProperPrefixes1[5]);
        }

        [TestMethod]
        public void KMPSearch_GetLongestProperPrefixWhichIsAlsoSuffix_Test3()
        {
            List<int> longestProperPrefixes1 = KMPSearch.GetLongestProperPrefixWhichIsAlsoSuffix("ddgddcddgdd");
            Assert.AreEqual(0, longestProperPrefixes1[0]);
            Assert.AreEqual(1, longestProperPrefixes1[1]);
            Assert.AreEqual(0, longestProperPrefixes1[2]);
            Assert.AreEqual(1, longestProperPrefixes1[3]);
            Assert.AreEqual(2, longestProperPrefixes1[4]);
            Assert.AreEqual(0, longestProperPrefixes1[5]);
            Assert.AreEqual(1, longestProperPrefixes1[6]);
            Assert.AreEqual(2, longestProperPrefixes1[7]);
            Assert.AreEqual(3, longestProperPrefixes1[8]);
            Assert.AreEqual(4, longestProperPrefixes1[9]);
            Assert.AreEqual(5, longestProperPrefixes1[10]);
        }
    }
}

