﻿
#if nsp
namespace MapWinGIS
{
#endif
    using System;
    /// <summary>
    /// A grid color scheme defines how a grid will be colored.
    /// </summary>
    /// <remarks>A grid color scheme may either contain grid color breaks created by 
    /// the user, or may use a predefined color scheme. </remarks>
    #if nsp
        #if upd
            public class GridColorScheme : MapWinGIS.IGridColorScheme
        #else        
            public class IGridColorScheme
        #endif
    #else
        public class GridColorScheme
    #endif
    {
        #region IGridColorScheme Members
        /// <summary>
        /// Gets or sets the intensity of the ambient lighting for the color scheme. Only applies when creating hillshaded breaks.
        /// </summary>
        public double AmbientIntensity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Clears all color breaks in the color scheme.
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified color break from the color scheme. 
        /// </summary>
        /// <param name="Index">The index of the color break to be removed.</param>
        public void DeleteBreak(int Index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Restores the setings of the grid from the string generated by Grid.Serialize() method.
        /// </summary>
        /// <param name="newVal">The string with grid settings.</param>
        public void Deserialize(string newVal)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the direction the light source is pointing for the color scheme in the form of a vector which originates from the light 
        /// source. This only applies to hillshaded breaks.
        /// </summary>
        /// <returns>The direction the light source is pointing represented by a vector. </returns>
        public Vector GetLightSource()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The global callback is the interface used by MapWinGIS to pass progress and error events to interested applications. 
        /// </summary>
        /// \deprecated v4.9.3 Use GlobalSettings.ApplicationCallback instead.
        public ICallback GlobalCallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Inserts a break at the specified position of the color scheme.
        /// </summary>
        /// <param name="Position">The position to insert the break at.</param>
        /// <param name="Break">The grid color break.</param>
        public void InsertAt(int Position, GridColorBreak Break)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a break to the color scheme.
        /// </summary>
        /// <param name="BrkInfo">The grid color break.</param>
        public void InsertBreak(GridColorBreak BrkInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The key may be used by the programmer to store any string data associated with the object. 
        /// </summary>
        public string Key
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Retrieves the last error generated in the object. 
        /// </summary>
        public int LastErrorCode
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the azimuth, or compass heading of the light source. Only applies to hillshaded breaks.
        /// </summary>
        public double LightSourceAzimuth
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the elevation of the light source. Only applies to hillshaded breaks.
        /// </summary>
        public double LightSourceElevation
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the intensity of the light source for the color scheme. Only applies to hillshaded breaks. 
        /// </summary>
        public double LightSourceIntensity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// The color to use for the color scheme when drawing grid cells with a no-data value. 
        /// </summary>
        public uint NoDataColor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the number of color breaks in the color scheme.
        /// </summary>
        public int NumBreaks
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Serializes the setting of the grid to the string.
        /// </summary>
        /// <returns>The string with serialized setting of empty string on failure.</returns>
        public string Serialize()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the direction of the light source.
        /// </summary>
        /// <param name="Azimuth">The azimuth heading of the light source. Also known as the compass heading.</param>
        /// <param name="Elevation">The elevation of the light source.</param>
        public void SetLightSource(double Azimuth, double Elevation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads the values into the color scheme from pre-defined color scheme.
        /// </summary>
        /// <param name="LowValue">The lowest value in the grid. </param>
        /// <param name="HighValue">The highes value in the grid. </param>
        /// <param name="Preset">Optional. The pre-defined color scheme to be used. The default is 
        /// MapWinGIS.PredefinedColorScheme.SummerMountains. </param>
        public void UsePredefined(double LowValue, double HighValue, PredefinedColorScheme Preset)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a break from the color scheme using the specified index. 
        /// </summary>
        /// <param name="Index">The index of the color break to be returned.</param>
        /// <returns>The color break specified by the index.</returns>
        public GridColorBreak get_Break(int Index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the error message associated with the specified error code. 
        /// </summary>
        /// <param name="ErrorCode">The error code for which the error message is required.</param>
        /// <returns>The error message description for the specified error code.</returns>
        public string get_ErrorMsg(int ErrorCode)
        {
            throw new NotImplementedException();
        }

        #endregion

        /// <summary>
        /// A shortcut to apply new coloring type for each of the breaks of the colors scheme.
        /// </summary>
        /// <param name="ColoringType">New coloring type.</param>
        /// \new491 Added in version 4.9.1
        public void ApplyColoringType(ColoringType ColoringType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A shortcut to apply gradient model for each of the breaks of the colors scheme.
        /// </summary>
        /// <param name="GradientModel">New gradient model.</param>
        /// \new491 Added in version 4.9.1
        public void ApplyGradientModel(GradientModel GradientModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads color scheme from .mwleg XML file.
        /// </summary>
        /// <param name="mwlegFilename">Filename to read color scheme from.</param>
        /// <param name="nodeName">The name of node to read from (usually GridColoringScheme).</param>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool ReadFromFile(string mwlegFilename, string nodeName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes color scheme to the specified file.
        /// </summary>
        /// <param name="mwlegFilename">Filename to write color scheme into.</param>
        /// <param name="gridName">The name of the source grid without path (should be located in the same folder). Default value is empty string.</param>
        /// <param name="bandIndex">Band index the color scheme was created for. Default value is 1.</param>
        /// <returns>True on success.</returns>
        /// \new491 Added in version 4.9.1
        public bool WriteToFile(string mwlegFilename, string gridName = "", int bandIndex = 1)
        {
            throw new NotImplementedException();
        }
    }
#if nsp
}
#endif
