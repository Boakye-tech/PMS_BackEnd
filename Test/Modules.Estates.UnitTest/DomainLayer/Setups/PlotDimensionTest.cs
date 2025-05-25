// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/PlotDimensionTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:42 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class PlotDimensionTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreatePlotDimension()
		{
			// Arrange
			int plotDimensionId = 1;
			string plotDimension = "100X100";

			// Act
			var plotDimensions = PlotDimension.Create(plotDimensionId, plotDimension);

			// Assert
			Assert.Equal(plotDimensionId, plotDimensions.PlotDimensionId);
			Assert.Equal(plotDimension, plotDimensions.PlotDimensions);
		}

		[Theory]
		[InlineData(-1, "100X100", "Plot Dimension Id must be greater than zero.")]
		[InlineData(1, "", "Plot Dimensions cannot be empty or exceed 20 characters.")]
		[InlineData(1, null, "Plot Dimensions cannot be empty or exceed 20 characters.")]
		[InlineData(1, "This plot Dimension is way too long and exceeds the maximum allowed length", "Plot Dimensions cannot be empty or exceed 20 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(
			int plotDimensionId, string plotDimension, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => PlotDimension.Create(plotDimensionId, plotDimension));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdatePlotDimension()
		{
			// Arrange
			var plotDimension = PlotDimension.Create(1, "100 sqm");
			int newPlotDimensionId = 2;
			string newPlotDimension = "200 sqm";

			// Act
			plotDimension.Update(newPlotDimensionId, newPlotDimension);

			// Assert
			Assert.Equal(newPlotDimensionId, plotDimension.PlotDimensionId);
			Assert.Equal(newPlotDimension, plotDimension.PlotDimensions);
		}

		[Theory]
		[InlineData(-1, "100 sqm", "Plot Dimension Id must be greater than zero.")]
		[InlineData(1, "", "Plot Dimensions cannot be empty or exceed 20 characters.")]
		[InlineData(1, null, "Plot Dimensions cannot be empty or exceed 20 characters.")]
		[InlineData(1, "This plot Dimension is way too long and exceeds the maximum allowed length", "Plot Dimensions cannot be empty or exceed 20 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(int plotDimensionId, string plotDimension, string expectedMessage)
		{
			// Arrange
			var plotDimensions = PlotDimension.Create(1, "100X100sqm");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => plotDimensions.Update(plotDimensionId, plotDimension));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

