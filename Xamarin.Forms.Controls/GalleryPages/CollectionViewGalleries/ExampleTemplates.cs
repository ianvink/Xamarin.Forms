﻿using System;

namespace Xamarin.Forms.Controls.GalleryPages.CollectionViewGalleries
{
	internal class ExampleTemplates
	{
		public static DataTemplate PhotoTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					RowDefinitions = new RowDefinitionCollection { new RowDefinition(), new RowDefinition() },
					WidthRequest = 200,
					HeightRequest = 100
				};

				var image = new Image
				{
					HeightRequest = 100, WidthRequest = 100,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					FontSize = 12,
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center
				};

				caption.SetBinding(Label.TextProperty, new Binding("Caption"));
				
				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate SnapPointsTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					RowDefinitions = new RowDefinitionCollection { new RowDefinition(), new RowDefinition {Height = GridLength.Auto} },
					WidthRequest = 280,
					HeightRequest = 310,
				};

				var image = new Image
				{
					Margin = new Thickness(5),
					HeightRequest = 280,
					WidthRequest = 280,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					FontSize = 12,
					HorizontalOptions = LayoutOptions.Fill,
					BackgroundColor = Color.Aquamarine,
					HorizontalTextAlignment = TextAlignment.Center
				};

				caption.SetBinding(Label.TextProperty, new Binding("Caption"));
				
				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate CarouselTemplate()
		{
			return new DataTemplate(() =>
			{
				var grid = new Grid
				{
					BackgroundColor = Color.LightBlue,
					RowDefinitions = new RowDefinitionCollection
					{
						new RowDefinition(),
						new RowDefinition { Height = GridLength.Auto }
					}
				};

				var image = new Image
				{
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFill
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					BackgroundColor = Color.Gray,
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					Margin = new Thickness(5)
				};

				caption.SetBinding(Label.TextProperty, new Binding("Caption"));
				
				grid.Children.Add(image);
				grid.Children.Add(caption);

				Grid.SetRow(caption, 1);

				var frame = new Frame
				{
					Padding = new Thickness(5),
					Content = grid
				};

				return  frame;
			});
		}

		public static DataTemplate ScrollToIndexTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					BackgroundColor = Color.Bisque,

					RowDefinitions = new RowDefinitionCollection
						{ new RowDefinition(), new RowDefinition { Height = GridLength.Auto } },
					WidthRequest = 100,
					HeightRequest = 140
				};

				var image = new Image
				{
					Margin = new Thickness(5),
					HeightRequest = 100,
					WidthRequest = 100,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					HeightRequest = 40, WidthRequest = 100,
					BackgroundColor = Color.Crimson,
					Text = "Caption"
				};

				caption.SetBinding(Label.TextProperty, new Binding("Index", stringFormat:"Index {0}"));

				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate ScrollToItemTemplate()
		{
			return new DataTemplate(() =>
			{
				var templateLayout = new Grid
				{
					BackgroundColor = Color.Bisque,

					RowDefinitions = new RowDefinitionCollection { new RowDefinition(), new RowDefinition {Height = GridLength.Auto} },
					WidthRequest = 100,
					HeightRequest = 140
				};

				var image = new Image
				{
					Margin = new Thickness(5),
					HeightRequest = 100,
					WidthRequest = 100,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				var caption = new Label
				{
					HorizontalOptions = LayoutOptions.Fill,
					HorizontalTextAlignment = TextAlignment.Center,
					HeightRequest = 40, WidthRequest = 100,
					BackgroundColor = Color.Crimson,
					Text = "Caption"
				};

				caption.SetBinding(Label.TextProperty, new Binding("Date", stringFormat: "{0:d}"));
				
				templateLayout.Children.Add(image);
				templateLayout.Children.Add(caption);

				Grid.SetRow(caption, 1);

				return templateLayout;
			});
		}

		public static DataTemplate VariableSizeTemplate()
		{
			var height1 = 50;
			var width1 = 100;

			var height2 = 150;
			var width2 = 300;

			var index = 0;

			return new DataTemplate(() =>
			{
				var image = new Image
				{
					HeightRequest = index == 0 ? height1 : height2,
					WidthRequest = index == 0 ? width1 : width2,
					Aspect = Aspect.AspectFit
				};

				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				index += 1;

				return image;
			});
		}
	}
}