<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Charts.ascx.cs" Inherits="Admin_AdministratorEdit" %>
<div id="container" class="clearfix fixed fluid_">
    <div id="content">
        <div class="section">
            <div class="full">
                <div class="panel charts">
                    <div class="title-large">
                        <h2>
                            Bar Charts</h2>
                        <div class="theme">
                        </div>
                        <div class="drop">
                        </div>
                    </div>
                    <div class="content">
                        <div id="exp-bar-chart" class="charts">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="section">
            <div class="large">
                <div class="panel">
                    <div class="title">
                        <h4>
                            Pie Chart</h4>
                        <div class="theme">
                        </div>
                        <div class="drop">
                        </div>
                    </div>
                    <div class="content">
                        <div id="exp-bar-pie" class="charts">
                        </div>
                    </div>
                </div>
            </div>
            <div class="large">
                <div class="panel">
                    <div class="title">
                        <h4>
                            Zone Chart</h4>
                        <div class="theme">
                        </div>
                        <div class="drop">
                        </div>
                    </div>
                    <div class="content">
                        <div id="exp-bar-zone" class="charts">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="section" >
            <div class="full">
                <div class="panel charts">
                    <div class="title-large">
                        <h2>
                            Line Chart</h2>
                        <div class="theme">
                        </div>
                        <div class="drop">
                        </div>
                    </div>
                    <div class="content">
                        <div id="exp-line-chart" class="charts">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <table class="chartData" >
            <caption>
                2013 Employee Sales by Department</caption>
            <thead>
                <tr>
                    <td>
                    </td>
                    <th scope="col">
                        January
                    </th>
                    <th scope="col">
                        February
                    </th>
                    <th scope="col">
                        March
                    </th>
                    <th scope="col">
                        April
                    </th>
                    <th scope="col">
                        May
                    </th>
                    <th scope="col">
                        June
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">
                        Sales
                    </th>
                    <td>
                        190
                    </td>
                    <td>
                        160
                    </td>
                    <td>
                        40
                    </td>
                    <td>
                        120
                    </td>
                    <td>
                        30
                    </td>
                    <td>
                        70
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        Order
                    </th>
                    <td>
                        3
                    </td>
                    <td>
                        40
                    </td>
                    <td>
                        30
                    </td>
                    <td>
                        45
                    </td>
                    <td>
                        35
                    </td>
                    <td>
                        49
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        Customer    
                    </th>
                    <td>
                        10
                    </td>
                    <td>
                        180
                    </td>
                    <td>
                        10
                    </td>
                    <td>
                        85
                    </td>
                    <td>
                        25
                    </td>
                    <td>
                        79
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        Staff
                    </th>
                    <td>
                        40
                    </td>
                    <td>
                        80
                    </td>
                    <td>
                        90
                    </td>
                    <td>
                        25
                    </td>
                    <td>
                        15
                    </td>
                    <td>
                        119
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <!-- Webtunes Styler -->
    <div id="styler" class="auto_ off">
        <div id="styler-wrap">
            <div class="content">
                <div class="layout-slider" style="width: 100px; padding-top: 5px; float: left; margin: 5px 20px;
                    text-align: right;">
                </div>
                <div class="layout-slider" style="width: 140px; padding-top: 5px; float: left; margin: 5px 20px;
                    text-align: right;">
                    <span style="display: inline;">Panel Color</span>
                    <input type="hidden" name="panel-bar-color" id="panel-bar-color" size="7" />
                    <span style="display: inline;">Background Color</span>
                    <input type="hidden" name="style-backgound-color" id="style-backgound-color" size="7" />
                </div>
                <div class="layout-slider" style="width: 100px; padding-top: 5px; float: left; margin: 5px 20px;">
                    <span style="display: block;">Background Opacity</span>
                    <input id="style-background-transparency" type="slider" name="background-transparency"
                        value="20" />
                </div>
                <div class="layout-slider" style="width: 100px; padding-top: 5px; float: left; margin: 5px 20px;">
                    <span style="display: block;">Light Opacity</span>
                    <input id="style-background-shadow" type="slider" name="shadow-transparency" value="20" />
                </div>
                <div class="layout-slider" style="width: 100px; padding-top: 5px; float: left; margin: 5px 20px;">
                    <span style="display: block;">Panel Shadow</span>
                    <input id="style-panelbar-opacity" type="slider" name="shadow-transparency" value="20" />
                </div>
            </div>
            <div class="handle">
            </div>
            <div class="back-body">
            </div>
            <div class="back-hand">
            </div>
        </div>
    </div>
</div>
