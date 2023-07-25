using shoppingCartExample;

namespace ShoppingCartExample.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void AddItemWithExistingCodeItemIsNotAddedInShoppingCartReturnsFalse()
        {
            //arrange
            Dictionary<string, string> basket = new Dictionary<string, string>
            {
                {"123", "Obuoliai" }
            };

            string code = "123";
            string item = "Kriauses";

            //act
            bool actualResult = ShoppingCart.AddItem(
                basket,
                code,
                item
            );

            //assert

            Assert.IsFalse(actualResult);
            Assert.IsFalse(basket.ContainsValue("Kriauses"));
        }

        [TestMethod]
        public void AddItemWithNonExistingCodeItemIsAddedInShoppingCartReturnsTrue()
        {
            //arrange
            Dictionary<string, string> basket = new Dictionary<string, string>
            {
                {"124", "Obuoliai" }
            };

            string code = "123";
            string item = "Kriauses";

            //act
            bool actualResult = ShoppingCart.AddItem(
                basket,
                code,
                item
            );

            //assert

            Assert.IsTrue(actualResult);
            Assert.IsTrue(basket.ContainsValue("Kriauses"));
        }

        [TestMethod]
        public void DoesItemExistWithCodeThatDoesNotExistInShoppingCartReturnsFalse()
        {
            //arange
            Dictionary<string, string> basket = new Dictionary<string, string>()
            {
                {"124", "Obuoliai"}
            };

            string code = "123";

            //act
            bool actualResult = ShoppingCart.DoesItemByCodeExist( basket, code );
            
            //assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void DoesItemExistWithCodeThatExistInShoppingCartReturnsTrue()
        {
            //arange
            Dictionary<string, string> basket = new Dictionary<string, string>()
            {
                {"124", "Obuoliai"}
            };

            string code = "124";

            //act
            bool actualResult = ShoppingCart.DoesItemByCodeExist(basket, code);

            //assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void DoesItemExitsWithNullCodeReturnsFalse()
        {
            //arange
            Dictionary<string, string> basket = new Dictionary<string, string>()
            {
                {"124", "Obuoliai"}
            };

            //act
            bool actualResult = ShoppingCart.DoesItemByCodeExist(basket, null);

            //asert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void RemoveItemWithCodeThatDoesNotExistAndDoesNotRemoveItemFromShoppingCartReturnFalse()
        {
            // arrange
            Dictionary<string, string> basket = new Dictionary<string, string>()
            {
                {"124", "Obuoliai"},
                {"125", "Kriause"}
            };

            string code = "126";
            //act
            bool actualResult = ShoppingCart.RemoveItem(basket, code);


            //assert
            Assert.IsFalse(actualResult);
            Assert.AreEqual(2, basket.Count);
        }
    }
}