//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "PointParameters" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_point_parameters]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="param">
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "EXT_point_parameters", Version = "", EntryPoint = "glPointParameterfEXT")]
            public static void PointParameter(OpenTK.Graphics.OpenGL.ExtPointParameters pname, float param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_point_parameters]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "EXT_point_parameters", Version = "", EntryPoint = "glPointParameterfvEXT")]
            public static void PointParameter(OpenTK.Graphics.OpenGL.ExtPointParameters pname, [CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_point_parameters]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "EXT_point_parameters", Version = "", EntryPoint = "glPointParameterfvEXT")]
            public static void PointParameter(OpenTK.Graphics.OpenGL.ExtPointParameters pname, [CountAttribute(Computed = "pname")] ref float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_point_parameters]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "EXT_point_parameters", Version = "", EntryPoint = "glPointParameterfvEXT")]
            public static unsafe void PointParameter(OpenTK.Graphics.OpenGL.ExtPointParameters pname, [CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(1698)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glPointParameterfEXT(OpenTK.Graphics.OpenGL.ExtPointParameters pname, float param);

            [Slot(1702)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glPointParameterfvEXT(OpenTK.Graphics.OpenGL.ExtPointParameters pname, [CountAttribute(Computed = "pname")] float* @params);
        }
    }
}