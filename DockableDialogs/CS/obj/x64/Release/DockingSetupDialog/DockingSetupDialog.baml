   M S B A M L   `   `   `  ����   DockableDialogs=    7Revit.SDK.Samples.DockableDialogs.CS.DockingSetupDialog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       � SizeToContent$  WidthAndHeight=� � Title$ Dockable Dialog Setup��.��� .+��� .+���  �� Orientation$ 
Horizontal=�.+��� .��
New Guid�� -   $��
tb_newGuid���� $ 
Horizontal=�.+��� .��Left�� -   $��tb_left��.��10�� $ 
Horizontal=�.+��� .��Right�� -   $��tb_right��.��710�� $ 
Horizontal=�.+��� .��Top�� -   $��tb_top��.��10�� $ 
Horizontal=�.+��� .��Bottom�� -   $��	tb_bottom��.��710�� $ 
Horizontal=�.+��� .��Target Guid�� -   $��tb_targetGuid���� .��
Tab Target	� -   $��rb_ElementView�� 	� 	GroupName$ 	TabTarget�� d� 	IsChecked$ falseY�.��Element View	� -   $��rb_HostByLinkNavigator��$ 	TabTarget��$ falseY�.��Host By Link Nav	� -	   $��rb_ProjectBrowser��$ 	TabTarget��$ falseY�.��Project Browser	� -
   $��rb_PropertiesPalette��$ 	TabTarget��$
 trueY�.��Properties Palette	� -   $��rb_RebarBrowser��$ 	TabTarget��$ falseY�.��Rebar Browser	� -   $��rb_SystemNav��$ 	TabTarget��$ falseY�.��
System Nav	� -   $��rb_Null��$ 	TabTarget��$ falseY�.��Null�� .��DockPosition	� -   $��rb_top��$ DockPosition��.��Top	� -   $��rb_left��$ DockPosition��.��Left	� -   $��rb_right��$ DockPosition��.��Right	� -   $��	rb_bottom��$ DockPosition��$ FalseY�.��Bottom	� -   $��	rb_tabbed��$ DockPosition��$
 TrueY�.��Tabbed	� -   $��rb_floating��$ DockPosition��.��
Floating�� -   $��btn_ok��.��OK