﻿<Page
    x:Class="Calculator.MainMenu"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:Calculator"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">

	<Grid Background="LightBlue">
		<TextBlock HorizontalAlignment="Left" Margin="536,100,0,0" TextWrapping="Wrap" Text="Universal Calculator" VerticalAlignment="Top" Height="48" Width="221" FontSize="24"/>
		<Button Content="Math calculator&#xD;&#xA;" Margin="0,206,0,0" VerticalAlignment="Top" FontSize="24" Height="42" HorizontalAlignment="Center" Click="mathsCalculatorButtonClick"/>
		<Button Content="Mortgage Calculator&#xD;&#xA;" Margin="0,282,0,0" VerticalAlignment="Top" FontSize="24" HorizontalAlignment="Center" Height="42" Click="mortgageCalcButtonClick"/>
		<Button Content="Exit" Margin="0,360,0,0" VerticalAlignment="Top" FontSize="24" HorizontalAlignment="Center" Click="exitButton_Click"/>

	<Grid Background="#FFAEFFFF">
		<TextBlock HorizontalAlignment="Left" Margin="536,100,0,0" TextWrapping="Wrap" Text="Universal Calculator" VerticalAlignment="Top" Height="48" Width="221" FontSize="24"/>
		<Button Content="Math calculator&#xD;&#xA;" Margin="0,206,0,0" VerticalAlignment="Top" FontSize="24" Height="42" HorizontalAlignment="Center" Click="Button_Click"/>
		<Button Content="Mortgage Calculator&#xD;&#xA;" Margin="0,282,0,0" VerticalAlignment="Top" FontSize="24" HorizontalAlignment="Center" Height="42" Click="Button_Click_1"/>
		<Button Content="Currency Calculaor" Margin="0,360,0,0" VerticalAlignment="Top" HorizontalAlignment="Center" FontSize="24" Click="Button_Click_2"/>
		<Button Content="Exit" Margin="0,460,0,0" VerticalAlignment="Top" FontSize="24" HorizontalAlignment="Center" Click="Button_Click_3"/>
		<Image Source="images/abacus.PNG" Margin="1055,-282,82,282" />
	</Grid>
</Page>
