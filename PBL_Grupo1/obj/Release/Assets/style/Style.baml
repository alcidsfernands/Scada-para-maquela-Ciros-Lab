   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   rightAlignedColumn  �� 
TargetType �� Property �� Value3   -System.Windows.Media.Effects.DropShadowEffect  z-depth1    
BlurRadius    ShadowDepth    	Direction    Color  z-depth2  z-depth3  z-depth4  z-depth5  WindowCloseButton �� 
TargetType ��Name	 J� SnapsToDevicePixels
 ��Name �� Triggers P� Property P� Value �� 
TargetName  WindowControlButton  extendButton �� Triggers 	 extendButton2 
 ToggleButtonStyle1 �� BasedOn � UseLayoutRounding'   !System.Windows.VisualStateManager   VisualStateGroups%   System.Windows.VisualStateGroup   States    System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName R� KeyTime R� Value �� Color g� Duration  System.Windows.Visibility ��Name ��Name �� ContentStringFormat �� ContentStringFormat  TabItem.Static.Background  TabItem.Static.Border  TabItem.MouseOver.Border   TabItem.MouseOver.Background  TabItem.Disabled.Background  TabItem.Disabled.Border  TabItem.Selected.Border & "TabItem.Header.Selected.Background  WizardFirstTabItemStyle �Name  � RowDefinitions! � ColumnDefinitions" A�Name# �� Value$ �� Binding% �� RelativeSource& �� AncestorType  WizardTabItemStyle  WizardLastTabItemStyle  WizardTabControlStyle-   'System.Windows.Input.KeyboardNavigation'   TabNavigation( ��Name) ��Name* A�Name+ K� IsItemsHost,   TabIndex- K� ZIndex.   DirectionalNavigation�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      8d2http://schemas.microsoft.com/expression/blend/2008  Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  %N/  &	        &	 4     &	 a     &	 �     &	 �     &	 �     &	     &	 Q    &	 (    &		     &	
     &	 �    &	 �    &	 �    &	 �    &	 �    &	 �    &	 	    &	     &	 /    7  7  7  7  7  7  7  7  7  &	 c    7  7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  7  &	 �%    7  �� "  ��.���  �@��TextAlignment$ Right=�   $ 5Q�$ 1Q�$	 270Q�$ #CCCCCC��   $ 8Q�$	 2.5Q�$	 270Q�$ #BBBBBB��   $ 14Q�$	 4.5Q�$	 270Q�$ #BBBBBB��   $ 25Q�$ 8Q�$	 270Q�$ #BBBBBB��   $ 35Q�$ 13Q�$	 270Q�$ #BBBBBB���� "  ��.���  �@�FocusVisualStyle Z� ��  � �� �#413f44��  � ��$ 0q���  � �� �#333333��  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��� $ Chrome��#��z��#��z��#��z��	 . ._��� $
 	Presenter��#��z��#��z��#��z����. #	 z	  P�  �@J�IsMouseOver . . ���  � �� �#ce0000��  � �� �#ffffffP�  � �� . . ���  � �� �#a30000��  � �� �#ffffffP�  �@J�	IsFocused . . ��� $ Chrome�� � �� �#1ba1e2�� "  ��.���  �@�FocusVisualStyle Z� ��  � �� �#413f44��  � �� �#cccccc��  � ��$ 0q���  � �� �#333333��  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��� $ Chrome��#��z��#��z��#��z��	 . ._��� $
 	Presenter��#��z��#��z��#��z����. #	 z	  P�  � {� .  . ���  � �� �#333333��  � ��
 �����P�  �@J�IsMouseOver . . ���  � �� �	#FF595959��  � �� �	#FF595959��  � �� �#333333P�  � �� . . ���  � �� �#1ba1e2��  � �� �#1ba1e2��  � �� �#ffffffP�  �@J�	IsFocused . . ��� $ Chrome�� � �� �#1ba1e2�� "  ��.���  �@J�Opacity$	 0.7Q���  � ��$ 16�� P�  �@J�IsMouseOver . . ���  �@�Cursor$
 Hand����  �@J�Opacity$ 1Q���  � ��$ 20��P�  � {� .  . ���  �@J�Opacity$
 0.12Q��� "  ��.���  �@J�Opacity$	 0.7Q���  � ��$ 16�� P�  �@J�IsMouseOver . . ���  �@�Cursor$
 Hand����  �@J�Opacity$ 1Q���  � ��$ 20��P�  � {� .  . ���  �@J�Opacity$	 0.2Q��� "  d� �� "  d�.���  � ��$ Segoe UI)���  � ��$ 14.667(���  � �� �	#FF3F3F3F��  � ��$ 	10,0,10,2q���  � ��$ 30����  � ��$ 30����  � �� �� " d�.R��  .    CommonStates��.   
Normal��  	MouseOver��. �� .��T� $
 Fill�$ Bd��..�i� $ 0�� �� $ 	#7FE7E7E7��T� $ Stroke�$ Bd��..�i� $ 0�� �� $ 	#FF858585��  Pressed��. �� .��T� $
 Fill�$ Bd��..�i� $ 0�� �� $ 	#FF00AADE��T� $ Stroke�$ Bd��..�i� $ 0�� �� $ 	#FF00AADE��T� $ 0D�$ 
Foreground�$ ContentControl��..�i� $ 0�� �� $ White��  Disabled��. �� .��T� $ (UIElement.Visibility)�$ DisabledVisualElement��..�i� $ 0��  Visible=�  CheckStates��.   Checked��. �� .��T� $ (UIElement.Visibility)�$ checked��..�i� $ 0��  Visible=�T� $ 0D�$ 
Foreground�$ ContentControl��..�i� $ 0�� �� $ White��  	Unchecked��  Indeterminate��  FocusStates��.   Focused��. �� .��T� $ (UIElement.Visibility)�$ FocusedVisualElement��..�i� $ 0��  Visible=�  	Unfocused��.+��� $ Bd�����	#33F9F9F9���	#33B9B9B9$��1�� . �� $ checked�����	#FF00AADE���	#FF00AADE$��1�� . $y�	Collapsed=��� $ ContentControl��#��z��#��z��#��z�� . #��z��.���� $
 contentPresenter��#��z��#��z��# z  . �� $ FocusedVisualElement�����	#FF00AADE$��2�� . $y�	Collapsed=��� $ DisabledVisualElement�����	#99FFFFFF . $y�	Collapsed=��� $ #E0E0E0���� $ #E0E0E0���� $ 	#FF0099CC���� $ 	#FF0099CC���� $ #F0F0F0���� $ #D9D9D9���� $ #ACACAC���� $ #00779F���� "  ��.���  �@�FocusVisualStyle Z� ��  � �� �#989898��  � ��8   ��  � ��8  ��  � ��$ 0q���  � ��$	 6,2q���  � ��$ Stretch=���  � ��$ Stretch=���  � �� �� " ��.R�� $ templateRoot��	 .   �� �� $
��Auto ��� $
��Auto ��� .+��� $ topRail��#��z��$	��1,0q�#��z��$��4��$��0,0,0,-5q�� $��1��! �� �� $
��Auto ��� .+��� $ leftRail��#��z��$	��0,1q�#��z��$��4��$��0,0,-5,0q��� $ 	rightRail��$��2��#��z��$	��0,1q�#��z��$��4��$��-5,0,0,0q�A� $" 
mainBorder��$��1��#��z��#��z��$��26��$��26��	 . �� $
 contentPresenter��$��2��$��Header��|�.  $��Center=�$	��Top=�$��3,6,3,4q���. #	 z	 �� $ 
bottomRail��$��3��#��z��$	��1,0q�#��z��$��4��$��0q� �� $	# Top��$ �� *TabStripPlacement+% �� "& ��.a��� $ leftRail�� � y�$ Hidden=��� $ topRail�� � y�$ 	Collapsed=��� $ 
bottomRail�� � y�$ 	Collapsed=��� $# Bottom��$ �� *TabStripPlacement+% �� "& ��.a��� $ leftRail�� � y�$ Hidden=��� $ topRail�� � y�$ 	Collapsed=��� $ 
bottomRail�� � y�$ 	Collapsed=��� $# Right��$ �� *TabStripPlacement+% �� "& ��.a��� $ topRail�� � y�$ Hidden=��� $ leftRail�� � y�$ 	Collapsed=��� $ 	rightRail�� � y�$ 	Collapsed=��� $
# Left��$ �� *TabStripPlacement+% �� "& ��.a��� $ topRail�� � y�$ Hidden=��� $ leftRail�� � y�$ 	Collapsed=��� $ 	rightRail�� � y�$ 	Collapsed=��� $
# True��$ �� *IsMouseOver+% �� *Self+.a��� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� $# False��$ �� *	IsEnabled+% �� *Self+.a��� $ contentPresenter�� �@J�Opacity$
 0.56Q��� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� $
# True��$ �� *
IsSelected+% �� *Self+.a���  �@K�ZIndex$ 1���� 8   � ���� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� "  ��.���  �@�FocusVisualStyle Z� ��  � �� �#989898��  � ��8   ��  � ��8  ��  � ��$ 0q���  � ��$	 6,2q���  � ��$ Stretch=���  � ��$ Stretch=���  � �� �� " ��.R�� $ templateRoot��	 .   �� �� $
��Auto ��� $
��Auto ��� .+��� $ topRail��#��z��$	��1,0q�#��z��$��4��$��0,0,0,-5q�� $��1��! �� �� $
��Auto ��� .+��� $ leftRail��#��z��$	��0,1q�#��z��$��4��$��0,0,-5,0q��� $ 	rightRail��$��2��#��z��$	��0,1q�#��z��$��4��$��-5,0,0,0q�A� $" 
mainBorder��$��1��#��z��#��z��$��26��$��26��	 . �� $
 contentPresenter��$��2��$��Header��|�.  $��Center=�$	��Top=�$��3,6,3,4q���. #	 z	 �� $ 
bottomRail��$��3��#��z��$	��1,0q�#��z��$��4��$��0q� �� $# Right��$ �� *TabStripPlacement+% �� "& ��.a��� $ leftRail�� � y�$ 	Collapsed=��� $ 	rightRail�� � y�$ 	Collapsed=��� $
# Left��$ �� *TabStripPlacement+% �� "& ��.a��� $ leftRail�� � y�$ 	Collapsed=��� $ 	rightRail�� � y�$ 	Collapsed=��� $
# True��$ �� *IsMouseOver+% �� *Self+.a��� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� $# False��$ �� *	IsEnabled+% �� *Self+.a��� $ contentPresenter�� �@J�Opacity$
 0.56Q��� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� $
# True��$ �� *
IsSelected+% �� *Self+.a���  �@K�ZIndex$ 1���� 8   � ���� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� "  ��.���  �@�FocusVisualStyle Z� ��  � �� �#989898��  � ��8   ��  � ��8  ��  � ��$ 0q���  � ��$	 6,2q���  � ��$ Stretch=���  � ��$ Stretch=���  � �� �� " ��.R�� $ templateRoot��	 .   �� �� $
��Auto ��� $
��Auto ��� .+��� $ topRail��#��z��$	��1,0q�#��z��$��4��$��0,0,0,-5q�� $��1��! �� �� $
��Auto ��� .+��� $ leftRail��#��z��$	��0,1q�#��z��$��4��$��0,0,-5,0q��� $ 	rightRail��$��2��#��z��$	��0,1q�#��z��$��4��$��-5,0,0,0q�A� $" 
mainBorder��$��1��#��z��#��z��$��26��$��26��	 . �� $
 contentPresenter��$��2��$��Header��|�.  $��Center=�$	��Top=�$��3,6,3,4q���. #	 z	 �� $ 
bottomRail��$��3��#��z��$	��1,0q�#��z��$��4��$��0q� �� $	# Top��$ �� *TabStripPlacement+% �� "& ��.a��� $ 	rightRail�� � y�$ Hidden=��� $ topRail�� � y�$ 	Collapsed=��� $ 
bottomRail�� � y�$ 	Collapsed=��� $# Bottom��$ �� *TabStripPlacement+% �� "& ��.a��� $ 	rightRail�� � y�$ Hidden=��� $ topRail�� � y�$ 	Collapsed=��� $ 
bottomRail�� � y�$ 	Collapsed=��� $# Right��$ �� *TabStripPlacement+% �� "& ��.a��� $ leftRail�� � y�$ 	Collapsed=��� $ 	rightRail�� � y�$ 	Collapsed=��� $ 
bottomRail�� � y�$ Hidden=��� $
# Left��$ �� *TabStripPlacement+% �� "& ��.a��� $ leftRail�� � y�$ 	Collapsed=��� $ 	rightRail�� � y�$ 	Collapsed=��� $ 
bottomRail�� � y�$ Hidden=��� $
# True��$ �� *IsMouseOver+% �� *Self+.a��� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� $# False��$ �� *	IsEnabled+% �� *Self+.a��� $ contentPresenter�� �@J�Opacity$
 0.56Q��� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� $
# True��$ �� *
IsSelected+% �� *Self+.a���  �@K�ZIndex$ 1���� 8   � ���� $ 
mainBorder��8   � ���� $ 
mainBorder��8   � ���� "  ��.���  � ��$ 2q���  � ��$ Stretch=���  � ��$ Center=���  � ��
 ���� ��  � ��8   ��  � ��$ 1q���  � ��# � ����  � �� �� " ��.R�� $ templateRoot��}�. 	 . $' Local=�! �� $( ColumnDefinition0���� $( ColumnDefinition1��$��0 �  �� $) RowDefinition0��$
��Auto ��� $) RowDefinition1��$��* �.+�A� $* headerPanel��
������ + . $��2,2,2,0q�$, 1��$- 1���� $ contentPanel��#��z��#��z��#��z��$��0��$��1��$. 	Contained=�$, 2��$' Local=�._��� $
 PART_SelectedContentHost��$��SelectedContent��#��z��#	 z	  P�  �@��TabStripPlacement$	 Top=�. ��� $ headerPanel�� �@A�Rows$ 1��P�  �@��TabStripPlacement$ Bottom=�. ��� $ headerPanel�� �@A�Rows$ 1���� $ headerPanel�� � ��$ 1���� $ contentPanel�� � ��$ 0���� $ RowDefinition0�� � ��$ * ��� $ RowDefinition1�� � ��$
 Auto ��� $ headerPanel�� � ��$ 2,0,2,2q�P�  �@��TabStripPlacement$
 Left=�. ��� $ headerPanel�� �@A�Columns$ 1���� $ headerPanel�� � ��$ 0���� $ contentPanel�� � ��$ 0���� $ headerPanel�� � ��$ 0���� $ contentPanel�� � ��$ 1���� $ ColumnDefinition0�� � ��$
 Auto ��� $ ColumnDefinition1�� � ��$ * ��� $ RowDefinition0�� � ��$ * ��� $ RowDefinition1�� � ��$ 0 ��� $ headerPanel�� � ��$ 2,2,0,2q�P�  �@��TabStripPlacement$ Right=�. ��� $ headerPanel�� �@A�Columns$ 1���� $ headerPanel�� � ��$ 0���� $ contentPanel�� � ��$ 0���� $ headerPanel�� � ��$ 1���� $ contentPanel�� � ��$ 0���� $ ColumnDefinition0�� � ��$ * ��� $ ColumnDefinition1�� � ��$
 Auto ��� $ RowDefinition0�� � ��$ * ��� $ RowDefinition1�� � ��$ 0 ��� $ headerPanel�� � ��$ 0,2,2,2q�P�  � {� .  . ��� $ templateRoot��# � �� � ��