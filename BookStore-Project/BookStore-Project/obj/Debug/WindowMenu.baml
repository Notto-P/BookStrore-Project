   M S B A M L   `   `   `  ����L  HBookStore-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BookStore_ProjectBookStore_Project  5   	   "    BookStore_Project.WindowMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BookStore_Project     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$
 Menu��5	   	   $	��450��6   $	��800��6#   ���	#FFDAD3D3.��5
      �  � ColumnDefinitions 5   
   �� 5      $
��481* �6   �� 5      $
��129* �6   �� 5      $	��33* �6   �� 5      $
��149* �6   .+�5   
   �� -   5         ��Name$ btn_addUser��5      $8��2เพิ่ม/ลบ ผู้ใช้งาน��6&   $
��Left=�6C   $��49��6^   $��	10,61,0,0q�6j   $	��Top=�6}   $	��166��6�   $��24(�6�   
���   �6�   �� 5   
   -   5        $ btn_signout��5      $$��ออกจากระบบ��6&   $
��Left=�6;   $��46��6V   $��	10,10,0,0q�6b   $	��Top=�6u   $	��166��6�   $��24(�6�   
���   ����	#FFF55959���	#FF0B00966�   �� 5   
   -   5        $ btn_customerDetail��5      $<��6จัดการข้อมูลลูกค้า��6-   $
��Left=�6J   $��
206,66,0,0q�6e   $	��Top=�6y   $	��377��6�   $��77��6�   $��36(�6�   $
��Bold"�6�   ���	#FF5AE5FF���	#FF1477D2
���   �$��2��6  6  �� 5   
   -   5        $ btn_booksDetail��5      $?��9จัดการข้อมูลหนังสือ��6*   $
��Left=�6H   $��206,173,0,0q�6c   $	��Top=�6x   $	��377��6�   $��77��6�   $��36(�6�   $
��Bold"�6�   ���	#FFFBB57B���	#FFD24014
���   �$��2��6
  6  �� 5   
   -   5        $ btn_booksOrder��5      $3��-สั่งซื้อหนังสือ��6)   $
��Left=�6C   $��206,281,0,0q�6^   $	��Top=�6s   $	��377��6�   $��77��6�   $��36(�6�   $
��Bold"�6�   ���	#FFCBFB7B���	#FF2A8A39
���   �$��2��6  6  5      5      