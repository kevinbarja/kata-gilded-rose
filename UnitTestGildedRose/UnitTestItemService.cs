

using GildedRose;
using Xunit;

namespace UnitTestGildedRose
{
    
    public class UnitTestItemService
    {
        #region Req1
        [Fact]
        public void WhenItemIsNormal_QualityIs10AndSellIn5_QualityExpected9AndSellInExpected4()
        {
            Item normalItem = new Item("Normal", 10, 5);
            new ItemService().UpdateQuality(normalItem);
            Assert.True(normalItem.Quality == 9);
            Assert.True(normalItem.SellIn == 4);
        }

        [Fact]
        public void WhenItemIsNormal_QualityIs5AndSellIn2_QualityExpected4AndSellInExpected1()
        {
            Item normalItem = new Item("Normal", 5, 2);
            new ItemService().UpdateQuality(normalItem);
            Assert.True(normalItem.Quality == 4);
            Assert.True(normalItem.SellIn == 1);
        }

        [Fact]
        public void WhenItemIsNormal_QualityIs20AndSellIn21_QualityExpected19AndSellInExpected20()
        {
            Item normalItem = new Item("Normal", 20, 21);
            new ItemService().UpdateQuality(normalItem);
            Assert.True(normalItem.Quality == 19);
            Assert.True(normalItem.SellIn == 20);
        }
        #endregion

        #region Req2
        [Fact]
        public void WhenItemIsAgedBrie_QualityIs10AndSellIn5_QualityExpected11AndSellInExpected4()
        {
            Item agedBrieItem = new Item("Aged Brie", 10, 5);
            new ItemService().UpdateQuality(agedBrieItem);
            Assert.True(agedBrieItem.Quality == 11);
            Assert.True(agedBrieItem.SellIn == 4);
        }
        #endregion

        #region Req5
        [Fact]
        public void WhenItemIsAgedBrie_QualityIs50AndSellIn5_QualityExpected5AndSellInExpected4()
        {
            Item agedBrieItem = new Item("Aged Brie", 50, 5);
            new ItemService().UpdateQuality(agedBrieItem);
            Assert.True(agedBrieItem.Quality == 50);
            Assert.True(agedBrieItem.SellIn == 4);
        }

        [Fact]
        public void WhenItemIsBackstagePasses_QualityIs50AndSellIn5_QualityExpected5AndSellInExpected4()
        {
            Item backStageItem = new Item("Backstage pass", 50, 5);
            new ItemService().UpdateQuality(backStageItem);
            Assert.True(backStageItem.Quality == 50);
            Assert.True(backStageItem.SellIn == 4);
        }

        [Fact]
        public void WhenItemIsSulfuras_QualityIs30AndSellIn5_QualityExpected80AndSellInExpected4()
        {
            Item agedBrieItem = new Item("Sulfuras", 30, 5);
            new ItemService().UpdateQuality(agedBrieItem);
            Assert.True(agedBrieItem.Quality == 80);
            Assert.True(agedBrieItem.SellIn == 4);
        }
        #endregion

        #region Req7
        [Fact]
        public void WhenItemIsConjured_QualityIs10AndSellIn3_QualityExpected8AndSellInExpected2()
        {
            Item conjuredItem = new Item("Conjured", 10, 3);
            new ItemService().UpdateQuality(conjuredItem);
            Assert.True(conjuredItem.Quality == 8);
            Assert.True(conjuredItem.SellIn == 2);
        }

        [Fact]
        public void WhenItemIsConjured_QualityIs1AndSellIn2_QualityExpected0AndSellInExpected1()
        {
            Item conjuredItem = new Item("Conjured", 1, 2);
            new ItemService().UpdateQuality(conjuredItem);
            Assert.True(conjuredItem.Quality == 0);
            Assert.True(conjuredItem.SellIn == 1);
        }
        #endregion

        #region Req8
        [Fact]
        public void WhenItemIsBackstagePasses_QualityIs10AndSellIn20_QualityExpected11AndSellInExpected19()
        {
            Item backStageItem = new Item("Backstage pass", 10, 20);
            new ItemService().UpdateQuality(backStageItem);
            Assert.True(backStageItem.Quality == 11);
            Assert.True(backStageItem.SellIn == 19);
        }

        [Fact]
        public void WhenItemIsBackstagePasses_QualityIs13AndSellIn17_QualityExpected14AndSellInExpected16()
        {
            Item backStageItem = new Item("Backstage pass", 13, 17);
            new ItemService().UpdateQuality(backStageItem);
            Assert.True(backStageItem.Quality == 14);
            Assert.True(backStageItem.SellIn == 16);
        }

        [Fact]
        public void WhenItemIsBackstagePasses_QualityIs19AndSellIn11_QualityExpected38AndSellInExpected10()
        {
            Item backStageItem = new Item("Backstage pass", 19, 11);
            new ItemService().UpdateQuality(backStageItem);
            Assert.True(backStageItem.Quality == 20);
            Assert.True(backStageItem.SellIn == 10);
        }

        [Fact]
        public void WhenItemIsBackstagePasses_QualityIs304AndSellIn7_QualityExpected50AndSellInExpected6()
        {
            Item backStageItem = new Item("Backstage pass", 304, 7);
            new ItemService().UpdateQuality(backStageItem);
            Assert.True(backStageItem.Quality == 50);
            Assert.True(backStageItem.SellIn == 6);
        }

        [Fact]
        public void WhenItemIsBackstagePasses_QualityIs443232AndSellIn0_QualityExpected0AndSellInExpected0()
        {
            Item backStageItem = new Item("Backstage pass", 443232, 0);
            new ItemService().UpdateQuality(backStageItem);
            Assert.True(backStageItem.Quality == 0);
            Assert.True(backStageItem.SellIn == 0);
        }
        #endregion

    }
}
