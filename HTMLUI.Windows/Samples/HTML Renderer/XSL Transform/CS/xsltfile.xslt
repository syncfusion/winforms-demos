<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="html" />
	<xsl:template match="/">
		<html>
			<head>
				<title>
					<xsl:value-of select="/company/name" />
				</title>
				<style>
					body{ font-size:9pt; padding-left: 8}
					table{text-align: left;background-image:url('../../contact_image.jpg');background-position:center;background-repeat:no-repeat;}
					
				</style>
			</head>
			<body bgcolor="#ffffff">
				<h2 style="color:#2d3d79; text-align:center;">Welcome to <xsl:value-of select="/company/name" /></h2>
				<div align="center">
				<table width="100%" height="225" align="center">
					<tr style="color:#ffbf35; padding-left: 300;padding-top: 55; font-size:11pt; ">
						<td align="top" >
							<xsl:value-of select="/company/name" />							
						</td>
					</tr>
					<tr style="padding-left: 300;padding-top:10;">
							<td style="color:#ffffff;">
							<xsl:value-of select="/company/address1" />
							<br />
							<xsl:value-of select="/company/address2" />
							<br />
							<xsl:value-of select="/company/city" />
							<br />
							<xsl:value-of select="/company/state" />
							<br />
							<xsl:value-of select="/company/zip" />
							<br />
							<xsl:value-of select="/company/country" />
						</td>
					</tr>
				</table>
				</div>
			</body>			
		</html>
	</xsl:template>
</xsl:stylesheet>
