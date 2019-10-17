using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TemplatedParentBinding
{
	public partial class CustomControl : Control
	{
		public int CustomProperty
		{
			get { return (int)GetValue(CustomPropertyProperty); }
			set { SetValue(CustomPropertyProperty, value); }
		}
		
		public static readonly DependencyProperty CustomPropertyProperty =
			DependencyProperty.Register("CustomProperty", typeof(int), typeof(CustomControl), new PropertyMetadata(0));
	}
}
