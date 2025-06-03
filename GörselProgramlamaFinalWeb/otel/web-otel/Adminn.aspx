<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminn.aspx.cs" Inherits="otel.web_otel.Adminn" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Paneli</title>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600;700&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Poppins', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
        }

        .container {
            background: #fff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
            max-width: 900px;
            width: 100%;
            margin: 40px;
        }

        .header {
            font-size: 28px;
            font-weight: 700;
            color: #333;
            text-align: center;
            margin-bottom: 20px;
        }

        .row {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            gap: 20px;
            margin-bottom: 20px;
        }

        .box {
            flex: 1 1 30%;
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .box input,
        .box button {
            width: 100%;
            padding: 12px;
            border-radius: 5px;
            border: 1px solid #ddd;
            font-size: 16px;
            transition: border-color 0.3s, background-color 0.3s;
            box-sizing: border-box;
        }

        .box input:focus {
            border-color: #ebef0c;
            outline: none;
        }

        .box button,
        .aspNetButton {
            background-color: #ebef0c;
            color: #333;
            border: none;
            cursor: pointer;
            font-weight: 600;
            text-transform: uppercase;
        }

        .box button:hover,
        .aspNetButton:hover {
            background-color: #d6d80c;
        }

        p {
            font-size: 20px;
            font-weight: 600;
            color: #333;
            margin-bottom: 15px;
            width: 100%;
            text-align: center;
        }

        @media (max-width: 768px) {
            .box {
                flex: 1 1 45%;
            }
        }

        @media (max-width: 480px) {
            .box {
                flex: 1 1 100%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">Yönetici</div>
            <div class="row">
                <p>TC NO Giriniz:</p>
                <div class="box">
                    <asp:TextBox ID="txtInput" runat="server" placeholder="TC"></asp:TextBox>
                </div>
                <div class="box">
                    <asp:Button ID="btnARA" runat="server" Text="ARA" OnClick="btnARA_Click" CssClass="aspNetButton" />
                </div>
                <div class="box">
                    <asp:Button ID="btnSIL" runat="server" Text="SİL" OnClick="btnSIL_Click" CssClass="aspNetButton" />
                </div>
            </div>

            <div class="row">
                <div class="box"><asp:TextBox ID="TextBox1" runat="server" placeholder="İsim"></asp:TextBox></div>
                <div class="box"><asp:TextBox ID="TextBox2" runat="server" placeholder="Soyisim"></asp:TextBox></div>
                <div class="box"><asp:TextBox ID="TextBox3" runat="server" placeholder="Eposta"></asp:TextBox></div>
                <div class="box"><asp:TextBox ID="TextBox4" runat="server" placeholder="Telefon"></asp:TextBox></div>
            </div>

            <div class="row">
                <div class="box"><asp:TextBox ID="TextBox5" runat="server" placeholder="Giriş Tarihi" TextMode="Date"></asp:TextBox></div>
                <div class="box"><asp:TextBox ID="TextBox6" runat="server" placeholder="Çıkış Tarihi" TextMode="Date"></asp:TextBox></div>
                <div class="box"><asp:TextBox ID="TextBox7" runat="server" placeholder="Oda Tipi"></asp:TextBox></div>
                <div class="box"><asp:TextBox ID="TextBox8" runat="server" placeholder="Kalınan Gün"></asp:TextBox></div>
            </div>

            <div class="row">
                <div class="box"><asp:TextBox ID="TextBox9" runat="server" placeholder="Toplam Tutar"></asp:TextBox></div>
                <div class="box"><asp:TextBox ID="TextBox10" runat="server" placeholder="Kayıt Tarihi" TextMode="DateTime"></asp:TextBox></div>
            </div>
        </div>
    </form>
</body>
</html>