USE [Weedkend]
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (0, N'admin')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'user')
INSERT [dbo].[Account] ([UserName], [Password], [FullName], [Role], [PhoneNo], [Email], [Address], [Status]) VALUES (N'trungnam                 ', N'trungnam                                          ', N'Nguyễn Trung Nam', 0, N'0123456789', N'namnse130122@fpt.edu.vn', N'Biên Hòa - Đồng Nai', N'active    ')
