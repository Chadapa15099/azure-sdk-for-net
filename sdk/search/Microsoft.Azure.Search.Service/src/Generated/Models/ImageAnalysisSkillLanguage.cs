// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ImageAnalysisSkillLanguage.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ImageAnalysisSkillLanguageConverter))]
    public struct ImageAnalysisSkillLanguage : System.IEquatable<ImageAnalysisSkillLanguage>
    {
        private ImageAnalysisSkillLanguage(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// English
        /// </summary>
        public static readonly ImageAnalysisSkillLanguage En = "en";

        /// <summary>
        /// Chinese
        /// </summary>
        public static readonly ImageAnalysisSkillLanguage Zh = "zh";


        /// <summary>
        /// Underlying value of enum ImageAnalysisSkillLanguage
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ImageAnalysisSkillLanguage
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ImageAnalysisSkillLanguage
        /// </summary>
        public bool Equals(ImageAnalysisSkillLanguage e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ImageAnalysisSkillLanguage
        /// </summary>
        public static implicit operator ImageAnalysisSkillLanguage(string value)
        {
            return new ImageAnalysisSkillLanguage(value);
        }

        /// <summary>
        /// Implicit operator to convert ImageAnalysisSkillLanguage to string
        /// </summary>
        public static implicit operator string(ImageAnalysisSkillLanguage e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ImageAnalysisSkillLanguage
        /// </summary>
        public static bool operator == (ImageAnalysisSkillLanguage e1, ImageAnalysisSkillLanguage e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ImageAnalysisSkillLanguage
        /// </summary>
        public static bool operator != (ImageAnalysisSkillLanguage e1, ImageAnalysisSkillLanguage e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ImageAnalysisSkillLanguage
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ImageAnalysisSkillLanguage && Equals((ImageAnalysisSkillLanguage)obj);
        }

        /// <summary>
        /// Returns for hashCode ImageAnalysisSkillLanguage
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
