<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	 <xsl:template match="libro">
    <p><xsl:value-of select="autor"/> escribió "<xsl:value-of select="titulo"/>"</p>
  </xsl:template>
</xsl:stylesheet>