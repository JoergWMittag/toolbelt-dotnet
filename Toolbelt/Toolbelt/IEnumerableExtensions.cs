// Copyright (c) 2011 Jörg W Mittag <mailto:JoergWMittag+DotNET@GoogleMail.Com>
// This code is licensed under the terms of the MIT License (see LICENSE.markdown)

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Toolbelt
{
    namespace IEnumerableExtensions
    {
        public static class ForEachExtension
        {

            /// <summary>
            /// Iterates over the items of an arbitrary 
            /// <see cref='System.Collections.Generic.IEnumerable'>IEnumerable</see>.
            /// 
            /// This is essentially the more useful companion to 
            /// <see cref='System.Collections.Generic.List.ForEach'>List.ForEach</see>.
            ///
            /// </summary>
            /// <param name="xs">The collection over which to iterate.</param>
            /// <param name="f">
            /// The <see cref='Action'>action</see> to perform for 
            /// each element of the collection <see cref='xs'>xs</see>.
            /// </param>
            /// <typeparam name="T">The type of the collection items.</typeparam>
            public static void ForEach<T>(this IEnumerable<T>/*!*/ xs, Action<T>/*!*/ f)
            {
                Contract.Requires(xs != null);
                Contract.Requires(f != null);

                foreach (var x in xs) f(x);
            }
        }
    }
}
