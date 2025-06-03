<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="otel.WebForm1" %>

<!DOCTYPE html>
<html lang="tr">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Otel Rezervasyon Sayfası</title>
  <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600;700&display=swap" rel="stylesheet">
  <style>
      body {
          font-family: 'Poppins', sans-serif;
          margin: 0;
          padding: 20px;
          background-color: #f5f5f5;
      }
      .search-bar {
          background: #fff;
          padding: 20px;
          margin-bottom: 30px;
          border-radius: 8px;
          box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
      }
      .search-bar label {
          margin-right: 15px;
          font-weight: 600;
      }
      .search-bar input, .search-bar select {
          padding: 8px 12px;
          margin-right: 20px;
          border: 1px solid #ccc;
          border-radius: 4px;
          font-size: 14px;
      }
      .search-bar button {
          background-color: #ebef0c;
          color: #fff;
          padding: 8px 16px;
          border: none;
          border-radius: 4px;
          cursor: pointer;
          font-size: 14px;
      }
      .container {
          display: flex;
          gap: 30px;
      }
      .room-list {
          flex: 3;
      }
      .room-card {
          background-color: #fff;
          border-radius: 8px;
          box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
          margin-bottom: 20px;
          display: flex;
          align-items: center;
      }
      .room-image {
          width: 200px;
          height: 150px;
          background-size: cover;
          background-position: center;
          border-top-left-radius: 8px;
          border-bottom-left-radius: 8px;
      }
      .room-details {
          flex: 1;
          padding: 20px;
      }
      .room-details h2 {
          margin-top: 0;
          margin-bottom: 10px;
      }
      .room-details p {
          margin-bottom: 15px;
      }
      .room-details .price {
          font-weight: 600;
          font-size: 18px;
      }
      .room-details .button {
          background-color: #ebef0c;
          color: #fff;
          padding: 8px 16px;
          border: none;
          border-radius: 4px;
          cursor: pointer;
          font-size: 14px;
          text-decoration: none;
      }
      .sidebar {
          flex: 1;
          background-color: #fff;
          border-radius: 8px;
          box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
          padding: 20px;
      }
      .sidebar h3 {
          margin-top: 0;
      }
      .form-group {
          margin-bottom: 20px;
      }
      .form-group label {
          display: block;
          font-weight: 600;
          margin-bottom: 5px;
      }
      .form-group label span {
          color: #ff0000;
      }
      .form-group input, .form-group select {
          width: 100%;
          padding: 8px 12px;
          border: 1px solid #ccc;
          border-radius: 4px;
          font-size: 14px;
      }
      .form-group .phone-group {
          display: flex;
          gap: 10px;
      }
      .form-group .phone-group select {
          width: 30%;
      }
      .form-group .phone-group input {
          width: 70%;
      }
      .confirm-button {
          background-color: #ebef0c;
          color: #fff;
          padding: 10px 20px;
          border: none;
          border-radius: 4px;
          cursor: pointer;
          font-size: 14px;
      }
      .back-button {
          position: absolute;
          top: 20px;
          right: 20px;
          background-color: #ebef0c;
          color: #fff;
          padding: 8px 16px;
          border: none;
          border-radius: 4px;
          cursor: pointer;
          font-size: 14px;
          text-decoration: none;
      }
  </style>
</head>
<body>
  <form id="form1" runat="server">
      <div class="search-bar">
          <label for="check-in">Giriş Tarihi:</label>
          <asp:TextBox ID="TextBoxGirisTarihi" runat="server" TextMode="Date" AutoPostBack="true" OnTextChanged="TextBoxGirisTarihi_TextChanged"></asp:TextBox>
          <label for="check-out">Çıkış Tarihi:</label>
          <asp:TextBox ID="TextBoxCikisTarihi" runat="server" TextMode="Date" AutoPostBack="true" OnTextChanged="TextBoxCikisTarihi_TextChanged"></asp:TextBox>
          <button type="button" onclick="searchRooms()">Ara</button>
      </div>

      <div class="container">
          <div class="room-list">
              <div class="room-card">
                  <div class="room-image" style="background-image: url('standart.jpg');"></div>
                  <div class="room-details">
                      <h2>STANDART ODA</h2>
                      <p>Ortalama 26 m² olan Deluxe odalarda çalışma masası, konforlu 2 adet tek kişilik yatak...</p>
                      <p class="price">€125.00</p>
                      <p>KAHVALTI HARİÇ İPTAL EDİLEMEZ FİYAT</p>
                      <a href="web-otel\HAKKIMIZDA\anasayfa.aspx" class="button">Odayı Gör</a>
                      <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="true" GroupName="odasecim" OnCheckedChanged="RadioButton1_CheckedChanged" />
                  </div>
              </div>

              <div class="room-card">
                  <div class="room-image" style="background-image: url('deluxe2.jpg');"></div>
                  <div class="room-details">
                      <h2>DELUXE ODA</h2>
                      <p>Ortalama 26 m² olan Deluxe odalarda çalışma masası, konforlu king yatak...</p>
                      <p class="price">€135.00</p>
                      <p>KAHVALTI HARİÇ İPTAL EDİLEMEZ FİYAT</p>
                      <a href="web-otel/HAKKIMIZDA/deluxe.aspx" class="button">Odayı Gör</a>
                      <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="true" GroupName="odasecim" OnCheckedChanged="RadioButton2_CheckedChanged" />
                  </div>
              </div>

              <div class="room-card">
                  <div class="room-image" style="background-image: url('executive3.jpg');"></div>
                  <div class="room-details">
                      <h2>EXECUTIVE CLUB ODA</h2>
                      <p>Ortalama 26 m² olan Deluxe odalarda çalışma masası, konforlu king yatak...</p>
                      <p class="price">€145.00</p>
                      <p>KAHVALTI HARİÇ İPTAL EDİLEMEZ FİYAT</p>
                      <a href="web-otel/HAKKIMIZDA/executive.aspx" class="button">Odayı Gör</a>
                      <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="true" GroupName="odasecim" OnCheckedChanged="RadioButton3_CheckedChanged" />
                  </div>
              </div>

              <div class="room-card">
                  <div class="room-image" style="background-image: url('web-otel/HAKKIMIZDA/img2/super2.jpg');"></div>
                  <div class="room-details">
                      <h2>SUPERİOR ODA</h2>
                      <p>Ortalama 26 m² olan Deluxe odalarda çalışma masası, konforlu king yatak...</p>
                      <p class="price">€155.00</p>
                      <p>KAHVALTI HARİÇ İPTAL EDİLEMEZ FİYAT</p>
                      <a href="web-otel/HAKKIMIZDA/superior.aspx" class="button">Odayı Gör</a>
                      <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="true" GroupName="odasecim" OnCheckedChanged="RadioButton3_CheckedChanged" />
                  </div>
              </div>

              <div class="room-card">
                  <div class="room-image" style="background-image: url('web-otel/HAKKIMIZDA/img2/presen3.jpg');"></div>
                  <div class="room-details">
                      <h2>PRESİDENTİAL SUİT</h2>
                      <p>Ortalama 26 m² olan Deluxe odalarda çalışma masası, konforlu king yatak...</p>
                      <p class="price">€170.00</p>
                      <p>KAHVALTI HARİÇ İPTAL EDİLEMEZ FİYAT</p>
                      <a href="web-otel/HAKKIMIZDA/presidential.aspx" class="button">Odayı Gör</a>
                      <asp:RadioButton ID="RadioButton5" runat="server" AutoPostBack="true" GroupName="odasecim" OnCheckedChanged="RadioButton3_CheckedChanged" />
                  </div>
              </div>
          </div>

          <div class="sidebar">
              <h3>Misafir Bilgileri</h3>
              <div class="form-group">
                  <label for="first-name">Ad <span>*</span></label>
                  <asp:TextBox ID="TextBoxAd" runat="server" OnTextChanged="TextBoxAd_TextChanged"></asp:TextBox>
              </div>
              <div class="form-group">
                  <label for="last-name">Soyad <span>*</span></label>
                  <asp:TextBox ID="TextBoxSoyad" runat="server" OnTextChanged="TextBoxSoyad_TextChanged"></asp:TextBox>
              </div>
              <div class="form-group">
                  <label for="email">Email <span>*</span></label>
                  <asp:TextBox ID="TextBoxEmail" runat="server" OnTextChanged="TextBoxEmail_TextChanged"></asp:TextBox>
              </div>
              <div class="form-group">
                  <label for="tc-no">TC No <span>*</span></label>
                  <asp:TextBox ID="TextBoxTCNo" runat="server" OnTextChanged="TextBoxTCNo_TextChanged"></asp:TextBox>
              </div>
              <div class="form-group">
                  <label for="phone">Telefon <span>*</span></label>
                  <div class="phone-group">
                      <asp:TextBox ID="TextBoxTelefon" runat="server" OnTextChanged="TextBoxTelefon_TextChanged"></asp:TextBox>
                  </div>
              </div>
              <asp:Button ID="ButtonRezervasyonYap" runat="server" CssClass="confirm-button" Text="Rezervasyon Yap" OnClick="ButtonRezervasyonYap_Click" />
              <asp:Label ID="Label1" runat="server" Text="Toplam Tutar:"></asp:Label>
          </div>
      </div>

      <a href="web-otel/otel.aspx" class="back-button">Geri</a>
  </form>

  </body>
</html>