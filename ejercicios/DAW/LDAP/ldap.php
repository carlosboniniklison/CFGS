class loginLDAP {
	
	public function new_login($usu,$pass) {
			if ($usu!='' && $pass!='') {
	
			$adServer = "ldap://NOMBRESERVIDOR.NOMBREDOMINIO"; //EJEM srv.contoso.local
			$ldap = ldap_connect($adServer);
			$username = $usu;
			$password = $pass;
			$ldaprdn = ' ----NOMBREDOMINIO---- '. "\\" . $username;
	
			ldap_set_option($ldap, LDAP_OPT_PROTOCOL_VERSION, 3);
			ldap_set_option($ldap, LDAP_OPT_REFERRALS, 0);
	
			$bind = @ldap_bind($ldap, $ldaprdn, $password);
	
			if ($bind) {
				@ldap_close($ldap);
				return true;
			} else {
				return false;
			}
		} else {
			return false;
		}
	}
}
// https://www.phpcentral.com/pregunta/1059/login-ldap-conflictos-para-conectar-con-mi-base-de-datos-ldap-connect
