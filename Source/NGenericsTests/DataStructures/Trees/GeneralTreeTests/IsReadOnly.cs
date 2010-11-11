/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.Trees;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.GeneralTreeTests
{
    [TestFixture]
    public class IsReadOnly : GeneralTreeTest
    {

        [Test]
        public void Simple()
        {
            var generalTree = new GeneralTree<int>(4);
            Assert.IsFalse(generalTree.IsReadOnly);

            generalTree = GetTestTree();
            Assert.IsFalse(generalTree.IsReadOnly);
        }

    }
}