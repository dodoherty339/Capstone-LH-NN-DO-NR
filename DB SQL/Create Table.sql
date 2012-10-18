create table items
(
	AuditNum varchar(20) primary key,
	StoreNumber varchar(2),
	IDNumber varchar(20),
	Active varchar(5),
	ItemDesc varchar(150),
	DeptAudit varchar(20),
	VenderAudit varchar(20),
	VenderPart varchar(10),
	TaxCode numeric(1,0),
	OnHand varchar(5),
	Reorder varchar(5),
	Restock varchar(5),
	Cost numeric(12,2),
	Retail numeric(12,2),
	SoldDol varchar(10),
	SoldNum varchar(10),
	PriceMethod varchar(10),
	ListPrice varchar(5),
	MarginMarkup varchar(5),
	ListPercent varchar(5),
	CostPercent varchar(5),
	Vol1Desc varchar(5),
	Vol1Qty varchar(5),
	Vol2Retail varchar(5),
	Vol2Desc varchar(5),
	Vol2Qty varchar(5),
	Vol3Retail varchar(5),
	Vol3Desc varchar(5),
	Vol3Qty varchar(5),
	Vol1Retail varchar(5),
	Vol4Desc varchar(5),
	Vol4Qty varchar(5),
	Vol4Retail varchar(5),
	ForceVolume varchar(5),
	PerUnitLabel varchar(5),
	PerUnitAmount varchar(5),
	LastPurchaseDateTime datetime,
	BSTCashDefault varchar(5),
	BSTCreditDefault varchar(5),
	BSTAdded varchar(5),
)

insert into items
	values('1234567','1','123456789','true','DVD','T','T','blank','1','5','N','N','8.00','15.00','15.00','5','4','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','False','Each','2011-01-01 02:30:45','0','0','0')
	
insert into items
	values('1589674','1','864751293','true','Soft Drink','T','T','blank','2','5','N','N','.50','1.50','1.50','10','4','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','False','Each','2011-01-20 12:30:35','0','0','0')

insert into items
	values('7586942','1','468539712','true','DVD','T','T','blank','1','5','N','N','8.50','15.00','15.00','2','4','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','False','Each','2011-01-15 8:05:35','0','0','0')
	
insert into items
	values('5896324','1','458796321','true','Poster','T','T','blank','1','6','N','N','5.00','10.00','10.00','9','4','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','False','Each','2011-02-03 13:01:25','0','0','0')	
	
insert into items
	values('7856912','1','537914682','true','Keychain','T','T','blank','1','6','N','N','1.00','5.00','5.00','4','4','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','False','Each','2011-02-10 16:15:45','0','0','0')	
	

	
	
	