USE [master]
GO
/****** Object:  Database [QuestionBank_DB]    Script Date: 1/21/2024 9:19:00 PM ******/
CREATE DATABASE [QuestionBank_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuestionBank_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QuestionBank_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuestionBank_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QuestionBank_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuestionBank_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuestionBank_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuestionBank_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuestionBank_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuestionBank_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuestionBank_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuestionBank_DB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [QuestionBank_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [QuestionBank_DB] SET  MULTI_USER 
GO
ALTER DATABASE [QuestionBank_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuestionBank_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuestionBank_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuestionBank_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuestionBank_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuestionBank_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuestionBank_DB', N'ON'
GO
ALTER DATABASE [QuestionBank_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuestionBank_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuestionBank_DB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 1/21/2024 9:19:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Difficulties]    Script Date: 1/21/2024 9:19:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Difficulties](
	[DifficultyId] [int] IDENTITY(1,1) NOT NULL,
	[Difficulty] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_dbo.Difficulties] PRIMARY KEY CLUSTERED 
(
	[DifficultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 1/21/2024 9:19:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[LessonId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_dbo.Lessons] PRIMARY KEY CLUSTERED 
(
	[LessonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionOptions]    Script Date: 1/21/2024 9:19:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionOptions](
	[OptionId] [int] IDENTITY(1,1) NOT NULL,
	[Option] [nvarchar](20) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[OptionNumber] [int] NOT NULL,
 CONSTRAINT [PK_dbo.QuestionOptions] PRIMARY KEY CLUSTERED 
(
	[OptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 1/21/2024 9:19:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](50) NOT NULL,
	[TypeId] [int] NOT NULL,
	[DifficultyId] [int] NOT NULL,
	[LessonId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Questions] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionTypes]    Script Date: 1/21/2024 9:19:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionTypes](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.QuestionTypes] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202312291254288_Create_Database', N'QuestionBank.DataLayer.Migrations.Configuration', 0x1F8B0800000000000400E55CDB6EE336107D2FD07F10F4D416592BCE628136B07791759222682EDB3859F42D6024DA112A51AA4405368A7E591FFA49FD855277F1265117DBDA2D1658C4F270389C39331C9127F9F7EF7F661F36AEA3BDC220B43D34D7A793635D83C8F42C1BADE77A84576F7ED43FBCFFF69BD985E56EB4CFB9DCDB588E8C44E15C7FC1D83F358CD07C812E0827AE6D065EE8ADF0C4F45C03589E71727CFC93319D1A90A8D0892E4D9BDD4708DB2E4C3E908F0B0F99D0C711706E3C0B3A61F69C7CB34CB46AB7C085A10F4C38D77F8D608889111F01FA7D720E30B8065B184C880A0C3758D7CE1C1B10AB96D059E91A40C8C320163F7D0CE112071E5A2F7DF200380F5B1F12B915704298ADE5B414575DD6F149BC2CA31C98AB32A3107B6E4B85D3B7999F0C7678276FEB851F89272F88C7F1365E75E2CDB97E0DC3D043E153E2725D63673C5D38412C2DF5781AAA09A5E648130B1F15D021088BFF1D698BC8C15100E70846380064E4A7E8D9B1CD5FE0F6C1FB1DA2398A1CA7BA00B204F21DF5803CFA14783E0CF0F61EAEA8655D59BA66D0A30D767831981B99AEFB0AE1B727BA764B0C01CF0E2CB052F1D1127B01FC192218000CAD4F00631890505F5930F13667033363FC7F3E1B0127C9395DBB019B6B88D6F865AE9F9024BBB437D0CA1F64063C229B6428198383080A0C6426BD05AFF63AB197993E8F55A86BF7D04924C217DB4F9367927F9B46F629F50E3128F0DC7BCFA90CA7049E1E40B086240F1FBC3AA9A517052663EACC28315A8B5C5A6577E8D27A4680DDDC802EE8AD8EDD177EF3396B30FC6E180C3313C7D3352FB45EC7B9BD5AD92689E4B6AF26D5C2A19A9779AA0D979479BAD527659EBA6DEB47E949159B45A3A4F6F3C24D6B118CE8BAAE3BBFB93A66324F652AF06B6165A435921314954915CB631CB689452ADF1885584CD5FF89ACC8F3ADCB7C259203157C56E3084A3F5D8DDA16FF36B56CB8F25FCD60E906301D5313D3B7F634343735D5AA57061485A82FF0334523C07B6A4917AC9723F785F374C6DD37EA9D3BBAB6B932FC8E26DB14A45B5FAF7C48F69681F68252D708B222EF6BDBE6845A3F3C5C46A4FD82341FC88F232CFA6D9A1CC5424F35442A903E238DB66927060B5F66F38E9EF6C305B234A5F63E0D08EF03121D8258DB27182546CDF51F3857374D5138A49C823940A26798EA2CDAEFD039742086DA99991E882D4068028B8F3A719D453F210902831899C059901949CAD908F3D96423D3F681A3B20E6670AB93A4D8C46232F69B73E8431467914AC0FA5A514CC638B0C95F33A382C356F01434508A38AA7B93DB016CEB9A377E3AFE1563E468962F4F0553752F1B7DD02D8FF11056ED11ED5C0FD4843A7943C483ADE8E6DB835B7E92A09A42E341B26C2D2A50911F947682AF2C7AFD4D395C854EBA9D96C5923EDFD96155A67B2C7EA26A833F56FCD62C490537E2567F88EA5B8D623F4B06476FDA14C777B564040C32036EB6C5ED2DF736F718C2EC852ECCDE1A58A8C51A9710D3B79ABA56F6DFE27695832CADA7F286C16962D3415155B1BF41BB4E2BDF8B28EA2FF615A9EA42425163E2F61A7DD53465545600C0EB656E2F2AB2B5D71C2C3E555F8B8AE55161E5E0AEFA0A545157A08D2D35F4F2DBBB467450D9E8A6A6E6BC637BDED77D35ADB840359D2583F9953FD592BBB3BEFB6BD7FF095628C9C2760D9F4A508683617A74A20C40BEF768DD7D0C053AAAD31028CD4A9CB2E3F2839D620F2BB94A464A56CA1ECC0C09AB6976037CDF46EB0ACB297BA22D538AD3E2CDB23DDFC74D75186628A0FD14D61633612F006BC87C4BA626965EDA4188E3D3CF67109FC92D2C97132B776CC94692CF436FCA7CF4F28D25978F7FA69128E67931BB39DFE6640A2FC92ADDB8634A0E3CF9CA2D1BAFC5D433E080407AD5BFF09CC8454D6734724D29F7A7AA257DC26B9819CC62B83E8DF323D7F8D261510A5A997603868D699DDAC7AD4981CCDDD5D7B4AAD3EB5EDF9AB58975B5D19437DF553DB2865CAE853E3AA9EAAA3F54916B6C0FF403C394EA1B768058AE2DEF8EDD6655FB8B73B5C114EB1B61ACF30E6A076196A86E115DA9065908CA0BED6A006417E4CD9A447ABA14B776A5F2C09048FBB81D00A2F28EDB1D13754A76BB33A49D3BAB63EF01E4DA6656A498BD689F99367996B5ACCDBF21C0F5B0A988AE11D7BCDA56DCBF2EB721866E12F5C9F20F67E1D864BDA5C00D40F68A442EBDCCD74F8EA727CC2F168C87E46F84A1E5085A7E29D39F0EDA9E39F576ECE646F2414BA24C95468F5E4160BE8080E3E7D4EAEC4A3DEFE04B7915EDC2F1DE893FCB3EB6C6A7EF9A7CCAEBA5592A89E9DC79EF15B2E066AEFF990C39D5AE7E7B4A471D697701C9CC53ED58FB6B10AAB7EAF4D5B1BD8C10A6828201F9B81693F7A7D87600F6F00CD69D809B27AD0AE13D1DBC6408FBC27D932577E2529A1FD9AD022B173B858C2947EE3267643DDD3E997E3B096795DC9707F33B176CBEEFE8C1BE9C37E6E2EE200C34D93973AF6BF24ED7CF4D079F7BE1B1FD3F986BFC4DECA1A963E381618B63B1BDF1CFBE7A9659EB60EF187CC54D661F96DB00249C0372C6BE7E8E5895E47138AAD6F82A5FEDC1E01EF85E5F06B78BBF50961CEB8AFF2A45138B2B3DDA9BEBD6B3479090B6A632528E8CE5249D8B15104D26275F34D2C0B68D13F3A222130A295BC06418802C56B7EC2E8CB2C6655785EA26177337F6CB3C13E255C03050A7AE08692A1296DD17C43393C1BEFE66746C6EDB318DACF552EADB3275F2D9D8A9627CDD90DDAFED1B312D0861FC0D16D96E2B7F098B6CF8A1BD2E55C47F170B4193DA680B992BB4F2F2FD9EB1281761CE756E200616D985CF026CAF8089C9D726A951C92F6F7E064E44442EDC67685DA1BB08FB11264B86EEB3431100E2BEA16EFE84F546DB3CCB2037C4128899365902BC431F23DBB10ABB2F05A75112157143921D96C5B1C4F1A1D97A5B68BAF590A2A2CC7D451FF5005DDF21CAC23BB404AFB08B6D8F21BC866B606EF38B48B992E640D06E9F9DDB601D0037CC7494E3C9478261CBDDBCFF0F0BE5BC34104E0000, N'6.4.4')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202401031626026_UpdateQuestionOptions', N'QuestionBank.DataLayer.Migrations.Configuration', 0x1F8B0800000000000400E55CDB6EE336107D2FD07F10F4D416592BCE628136B07791759222682EDB3859F42DA025DA112A51AE4405368A7E591FFA49FD855277F1269192EC78B75860114BC3E170E60C39248FFDEFDFFF4C3E6C7CCF788161E406686A8E47C7A601911D382E5A4DCD182FDFFC687E78FFED37930BC7DF189F0BB9B7891C6989A2A9F98CF1FAD4B222FB19FA201AF9AE1D0651B0C4233BF02DE004D6C9F1F14FD6786C41A2C224BA0C63721F23ECFA30FD403ECE0264C3358E81771338D08BF2E7E4CD3CD56ADC021F466B60C3A9F96B0C234C8CF808D0EFA37380C135D8C270445460B8C1A671E6B980583587DED2340042010689F8E96304E7380CD06ABE260F80F7B05D4322B7045E04F3B19C56E2AAC33A3E498665550D0B55761CE1C0D754387E9BFBC9629B77F2B659FA9178F282781C6F9351A7DE9C9AD7308A02143DA52E370DB6C7D3991726D2528F67A11A516A8E0CB1F051091D82B0E4DF91318B3D1C87708A608C43405A7E8A179E6BFF02B70FC1EF104D51EC79F50190219077D403F2E85318AC6188B7F770490DEBCA310D8B6E6DB1CDCBC65CCB6CDC5708BF3D318D5B62085878B0C44ACD47731C84F06788600830743E018C6148427DE5C0D4DB9C0D4C8FC9FF456F049C24E74CE3066CAE215AE1E7A9794292ECD2DD40A778901BF0885C92A1A40D0E63283090E9F416BCB8ABD45EA6FB22569169DC432F95889EDD75963CA3E26D16D9A7CC3BC4A030F0EF03AFD69C12787A00E10A923C7C089AA4E6411CDA8CA913ABC26823726995DDA14BEB3900EC160674416FBDEDBEF05BF4D980E177C36098E938E9AE7DA0CD3ACEDDE5D2B54924B77D35A94E1CAA7959A4DA704959A45B735216A9AB3B7F549E54B159D44A6A3F2FDC3616418BAEE3BA5BB7CF8EB9CC53950AFC585819E91CC9098AA64915CB131CEAC422936F8D4222A6EAFF5456E479ED69BE16C981267C56E3014CFDF46CA43BF9EBCC65C34DFFF50C962E00E3432A62FACE3D2DC54DC36CD52B03CA89A82FF073450780F7CC922E58AF5AEE0BE7598FBB2FD485DDDEC6FE0286FD0A14F5DA5037EB865F1B65CB8B7411ED9559E92A35D0AA52E93A80FC2A2A64DDEC52ABAC87CBADACF2906616F9F300970F9D724971C9A04A2B15489F9192DD76538385DBE2626F40FBE1023986D246210B08EF03121D8258774D304A8C9A9A3F70AE6EEBA27448D505731445F7303659B4DFA173E8410C8D333B3B5A9B81C8060E1F75E23A877E4212048609328137233D92947311E6B3C945B6BB069ECA3898C65A675289896567EC9B73B88628C9229580F5B5A2EC8C71609BBF26560D875AF01494628A386ADA13EE00B64D6520DF1DBF59397034CB87A782A9A66D4B1F74CB633C84557B443B5703B5A14E5E10F1602BF705FAE0969F49A8A6D0E12059361615A8C88F5C3BC15716BDFEA6BCDE0C9D563B9A93257D52B4C35999AEB1F88EEA05FEA1E2B761482AB81197FA43CCBEF528F6B36470F466457172EB4B5AC03037E0665BDE0373BBB9C708E61BBA28DF35B0504B34CE21A6EF474DA3AABFC5E52A07595A4F6D87C16962D3415155B9BE41B7492B5F8B28EA2FD715A9EA52425163EAF6067DF5346554D600C0EB65EE416AB28D17262C3E55B745E5F0A8B0727057DD02D5D4956863A71A7AF8FAAE111D79B6BAA9AD38EF589EF7755F43292E504D67C9607EE54FB5E4EE6CAEFEF4EA3FC1082559A857F0A904653818664727CA00E46B0FEDEA6328D051958640693EC5293BAE38D829D7B08AF56465B4A7FCC1C492F0A3263760BD76D1AAC697CA9F18F38C2C357B33D7670EF9990ECB8E0404A2D2DAB2271C84600599B7A46B62E9A51B463839FD5C80E44C6EE6F89C58B5624B1692A21F7A51E6A3572C2C857CF2378D4431638C59CDF9322757784946E92715537AE0C9CFDCB2F6464262031E08A5A48159E0C53E6A3BA3916BCA5844752DD9135EC3C46206C3D5699C1FB9C2970E8B52D0AAB41B306C4CE9A41FB736053277D7B76975A7376DDFDAB58975E9682A8AEFBA1E59412ED7421F9DD475351FAAC835EA03FD95614AD50D3B402C579677C76EBBAAFDC5B95E608AF51D60AC8B0A6A076196A8D688AE54832C04D5D5783D00B2ABF6764D223DFA5A8A1B6C5E57F1467FBAD49B7C5F19645965B80388D576CDDD51D6A464B76B4DB6176075EC3D805C21CE8A94BD97053953784FF222B8FDDB0B5C559C89980671CD8BEB2415F17C1B61E8A7511FCDFFF0669E4BC65B09DC00E42E49E4327A8079723C3E61BEF470385F40B0A2C8F1049B08E9B710E8A0ED99EFEF266E6EA53368526FEA147FF40242FB19841C77A85167575A7C075FCA67D12EFCF39DF8B3AA8C1B7CFAAECDA7BC5E9AF7929ACE9D205F21076EA6E69F699353E3EAB7A7ACD591711792CC3C358E8DBF06A1A1AB765F6FDBCB08612A281850B4D3E8BC3FFDB703B08767D7EE04DC3CA15608EFF1E05386B0D2DC379173272EA5B99BDD666099569A9A999ADF9B98A99A7955CB5DE69EAC36DC27077127B0A8D30E0B507CE783CDF71D3DD8978DC75C29BE0A374E7602DEEB02BFD3C578DB91EC5E1876FF0F4E1D7F47FCDAA4B6C381A1C681DDDE98715F3DFF4D3BD83B065F79C7DA877F37003DE815D96C5F3F7BAD4E3F793D12D9E1CD7C8D078C7B60A27D19AC33FEAA5B723C2CFEE58D367E59764438359D4540909095A632BA908C7F25ED8B15107526A785B412D4B6AD1DF3A222134A2957C0B11880C6D634EC2E5CB7D661D7859A3A17B34AF6CB8913E255C07D5027D508093412FEDF17C48093C1BEF9CEF6D0DCB663829BF6509ACB32755ADCA193D8F87943764FB76FC46850D5F89B30B2DCD67EED8B2CF891BBAA5424BFFD85A04D2DB4A5CC155A06C57ACF58548830E73A37100387ACC267217697C0C6E4B54DE6A8F46BA59F811713910B7F019D2B7417E3758CC990A1BFF0286A42523734F59FF2F1689B2739E486180231D325438077E863EC7A4E69F7A5E0344AA2222948F2C3B224963839345B6D4B4DB701525494BBAFACA31EA0BFF688B2E80ECDC10BEC62DB6304AFE10AD8DBE24253AEA43D10B4DB27E72E5885C08F721D557BF29160D8F137EFFF03FE63400EF44E0000, N'6.4.4')
GO
SET IDENTITY_INSERT [dbo].[Difficulties] ON 

INSERT [dbo].[Difficulties] ([DifficultyId], [Difficulty]) VALUES (1, N'آسان')
INSERT [dbo].[Difficulties] ([DifficultyId], [Difficulty]) VALUES (2, N'متوسط')
INSERT [dbo].[Difficulties] ([DifficultyId], [Difficulty]) VALUES (3, N'سخت')
SET IDENTITY_INSERT [dbo].[Difficulties] OFF
GO
SET IDENTITY_INSERT [dbo].[Lessons] ON 

INSERT [dbo].[Lessons] ([LessonId], [Name]) VALUES (1, N'ریاضی')
INSERT [dbo].[Lessons] ([LessonId], [Name]) VALUES (2, N'فارسی')
INSERT [dbo].[Lessons] ([LessonId], [Name]) VALUES (3, N'انگلیسی')
INSERT [dbo].[Lessons] ([LessonId], [Name]) VALUES (4, N'دانش فنی')
INSERT [dbo].[Lessons] ([LessonId], [Name]) VALUES (5, N'توسعه پایگاه داده')
INSERT [dbo].[Lessons] ([LessonId], [Name]) VALUES (6, N'طراحی وب')
SET IDENTITY_INSERT [dbo].[Lessons] OFF
GO
SET IDENTITY_INSERT [dbo].[QuestionOptions] ON 

INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (1, N'گزینه 1', 7, 1)
INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (2, N'گزینه 2', 7, 2)
INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (3, N'گزینه 3', 7, 3)
INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (4, N'گزینه 4', 7, 4)
INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (15, N'HTML', 13, 1)
INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (16, N'CSS', 13, 2)
INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (17, N'javascript', 13, 3)
INSERT [dbo].[QuestionOptions] ([OptionId], [Option], [QuestionId], [OptionNumber]) VALUES (18, N'Bootstap', 13, 4)
SET IDENTITY_INSERT [dbo].[QuestionOptions] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (2, N'کنایه را تعریف کنید.', 1, 1, 2)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (3, N'انواع فعل هارا در انگلیسی توضیح دهید', 1, 1, 3)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (4, N'آدرس آیپی را توضیح دهید', 1, 2, 4)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (5, N'در ویندوز فرم یک ماشین حساب طراحی کنید', 1, 3, 5)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (6, N'دیجیکالا را طراحی کنید.', 1, 3, 6)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (7, N'جواب درست را انتخاب کنید.', 2, 2, 1)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (8, N'تابع را تعریف کنید.', 1, 2, 1)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (9, N'What''s your name?', 1, 3, 3)
INSERT [dbo].[Questions] ([QuestionId], [Question], [TypeId], [DifficultyId], [LessonId]) VALUES (13, N'تستی طراحی وب', 2, 3, 6)
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
SET IDENTITY_INSERT [dbo].[QuestionTypes] ON 

INSERT [dbo].[QuestionTypes] ([TypeId], [Type]) VALUES (1, N'تشریحی')
INSERT [dbo].[QuestionTypes] ([TypeId], [Type]) VALUES (2, N'تستی')
INSERT [dbo].[QuestionTypes] ([TypeId], [Type]) VALUES (3, N'جاخالی')
SET IDENTITY_INSERT [dbo].[QuestionTypes] OFF
GO
/****** Object:  Index [IX_QuestionId]    Script Date: 1/21/2024 9:19:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_QuestionId] ON [dbo].[QuestionOptions]
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DifficultyId]    Script Date: 1/21/2024 9:19:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_DifficultyId] ON [dbo].[Questions]
(
	[DifficultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LessonId]    Script Date: 1/21/2024 9:19:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_LessonId] ON [dbo].[Questions]
(
	[LessonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TypeId]    Script Date: 1/21/2024 9:19:00 PM ******/
CREATE NONCLUSTERED INDEX [IX_TypeId] ON [dbo].[Questions]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[QuestionOptions] ADD  DEFAULT ((0)) FOR [OptionNumber]
GO
ALTER TABLE [dbo].[QuestionOptions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.QuestionOptions_dbo.Questions_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([QuestionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuestionOptions] CHECK CONSTRAINT [FK_dbo.QuestionOptions_dbo.Questions_QuestionId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Questions_dbo.Difficulties_DifficultyId] FOREIGN KEY([DifficultyId])
REFERENCES [dbo].[Difficulties] ([DifficultyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_dbo.Questions_dbo.Difficulties_DifficultyId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Questions_dbo.Lessons_LessonId] FOREIGN KEY([LessonId])
REFERENCES [dbo].[Lessons] ([LessonId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_dbo.Questions_dbo.Lessons_LessonId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Questions_dbo.QuestionTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[QuestionTypes] ([TypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_dbo.Questions_dbo.QuestionTypes_TypeId]
GO
USE [master]
GO
ALTER DATABASE [QuestionBank_DB] SET  READ_WRITE 
GO
