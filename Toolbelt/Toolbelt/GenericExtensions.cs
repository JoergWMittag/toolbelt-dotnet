// Copyright (c) 2011 Jörg W Mittag <mailto:JoergWMittag+DotNET@GoogleMail.Com>
// This code is licensed under the terms of the MIT License (see LICENSE.markdown)

using System;
using System.Diagnostics.Contracts;

namespace Toolbelt
{
    namespace GenericExtensions
    {
        public static class TapExtension
        {

            /// <summary>
            /// The K Combinator. 
            /// </summary>
            /// <param name="o">The object.</param>
            /// <param name="f">
            /// The <see cref='Action'>action</see> to perform.
            /// </param>
            /// <typeparam name="T">
            /// The type of &quot;receiver&quot; (when used as an 
            /// extension method).
            /// </typeparam>
            /// <returns><see cref='o'>o</see></returns>
            public static T/*!*/ Tap<T>(this T/*!*/ o, Action<T>/*!*/ f)
            {
                Contract.Requires(o != null);
                Contract.Requires(f != null);
                Contract.Ensures(Contract.Result<T>() != null);

                f(o);
                return o;
            }

            public static T/*!*/ Tap<T>(this T/*!*/ o, Action/*!*/ f)
            {
                Contract.Requires(o != null);
                Contract.Requires(f != null);
                Contract.Ensures(Contract.Result<T>() != null);

                f();
                return o;
            }
        }
    }
}
