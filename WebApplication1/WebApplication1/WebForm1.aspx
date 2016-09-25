<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        body, button, input, select, textarea, p {
            font: 12px/1.5 'Microsoft YaHei',tahoma,arial,'Hiragino Sans GB',\5b8b\4f53,sans-serif;
        }

        blockquote, body, button, dd, dl, dt, fieldset, form, h1, h2, h3, h4, h5, h6, hr, input, legend, li, ol, p, pre, td, textarea, th, ul {
            margin: 0;
            padding: 0;
        }

        .hotFloor {
            padding: 0 10px 10px 0;
            overflow: hidden;
            margin: 0 auto;
            width: 1240px;
        }

        .wraper {
            width: 1250px;
        }

        .item {
            width: 236px;
            background: #fff;
            float: left;
            margin: 10px 0 0 12px;
            text-decoration: none;
        }

            .item .imgContainer {
                width: 236px;
                height: 236px;
                overflow: hidden;
                position: relative;
            }

            .item .itemInfo {
                padding: 10px;
                height: 54px;
                overflow: hidden;
            }

            .item .priceBox {
                margin-bottom: 1px;
            }

                .item .priceBox .promoPrice {
                    font-size: 18px;
                    color: #ec462e;
                }

                .item .priceBox .originPrice {
                    font-size: 14px;
                    color: #999;
                    text-decoration: line-through;
                    margin-left: 20px;
                }

            .item .itemInfo .shortTitle {
                float: left;
                height: 28px;
                line-height: 28px;
                font-size: 16px;
                color: #000;
                margin: 0;
            }

            .item .itemInfo .clickUrl {
                float: right;
                width: 80px;
                height: 28px;
                font-size: 18px;
                display: block;
                line-height: 28px;
                color: #fff;
                background: #ff2442;
                text-align: center;
                text-decoration: none;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="hotFloor" style="background: #ff5a5d;">
                <div class="wraper">
                    <asp:Repeater ID="Repeater1" runat="server" >

                        <ItemTemplate>

                            <a href="#" class="item" target="_blank">
                                <div class="imgContainer">
                                    <div>
                                        <img src="https://asearch.alicdn.com/bao/uploaded/i2/14392063011483531/TB2JNH.bXXXXXXUXpXXXXXXXXXX_!!16044392-0-saturn_solar.jpg_250x250.jpg">
                                        <span class="overlay" style="background: rgba(255,93,90,.3)"></span>
                                    </div>
                                </div>
                                <div class="itemInfo">
                                    <p class="priceBox">

                                        <span class="promoPrice">￥<%# Eval("Price")%></span>
                                        <span class="originPrice">原价￥29.00</span>

                                    </p>
                                    <p class="shortTitle">
                                        限时优惠

                                    </p>
                                    <p class="clickUrl">马上抢</p>
                                </div>
                            </a>
                        </ItemTemplate>


                    </asp:Repeater>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
