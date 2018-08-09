#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
#if Syncfusion3_5
using System.Linq;
#endif

namespace Syncfusion.Windows.Forms.Diagram.DataBinding
{
    /// <summary>
    /// Defines a predicate delegate to be used for searching.
    /// </summary>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="PType"></typeparam>
    /// <param name="item"></param>
    /// <returns></returns>
    public delegate PType SearchPredicate<TType, PType>(TType item);

    /// <summary>
    /// Defines a utility of functions that is thoroughly reused for searching, indexing and many other future implementations.
    /// </summary>
    public class HelperUtil
    {

        /// <summary>
        /// Searches the specified collection.
        /// TType - the type of object passed on to SearchPredicate
        /// PType - the type of object that the SearchPredicate would return
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="itemToSearch">The item to search.</param>
        /// <param name="searchValue">The search value.</param>
        public static TType Search<TType, PType>(List<TType> collection, PType itemToSearch, SearchPredicate<TType, PType> searchValue)
        {
#if Syncfusion2_0
            return (TType)(collection.Find(delegate(TType t)
            {
                return itemToSearch.ToString() == searchValue(t).ToString();
            }));
#elif Syncfusion3_5
            var result = from TType t in collection
                         where searchValue( t ).ToString( ) == itemToSearch.ToString( )
                         select t;
            if ( result != null )
                return result.SingleOrDefault<TType>( );

            return default(TType);
            #endif
        }


        //public static bool FindItemInCollection<T>( List<T> collection ) {
        //    T item = collection.Find( delegate( T itemToFind )
        //    {
        //        return itemToFind.
        //    } );
        //}

        #region Comment
        /*
        public static int BinarySearch<T, K>( T[] array, K value, int index, int length, IComparer<T, K> comparer ) {
            if ( n == 0 )
                throw new ArgumentException( "Empty Array" );
            if ( n == 1 )
            {
                if ( item[i].ToString( ) == key.ToString( ) )
                    return i;
                return -1;
            }
            else
            {
                int j = i + n / 2;
                if ( item[j] <= key )
                    return BinarySearch( item, key, j, n - n / 2 );
                else
                    return BinarySearch( item, key, i, n / 2 );
            }
            return -1;

            //if ( comparer == null )
            //{
            //    comparer = Comparer<T>.Default;
            //}
            int num = index;
            int num2 = ( index + length ) - 1;
            while ( num <= num2 )
            {
                int num4;
                int num3 = num + ( ( num2 - num ) >> 1 );
                try
                {
                    num4 = comparer.Compare( array[num3], value );
                }
                catch ( Exception exception )
                {
                    throw new InvalidOperationException( "InvalidOperation_IComparerFailed" );
                }
                if ( num4 == 0 )
                {
                    return num3;
                }
                if ( num4 < 0 )
                {
                    num = num3 + 1;
                }
                else
                {
                    num2 = num3 - 1;
                }
            }
            return ~num;
        }*/
        #endregion


    }
}
