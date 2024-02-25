<template>
  
  <section class="ftco-section" ref="LoginRef">
		<div class="container">
			
			<div class="row justify-content-center">
                <div class="col-md-6 col-lg-5">
                    <div class="login-wrap p-4 p-md-5">
                        <div class="icon d-flex align-items-center justify-content-center">
                            <span class="fa fa-user-o"></span>
                        </div>
                        <h3 class="text-center mb-4">Đăng nhập</h3>
                        <form action="#" class="login-form">
                            <div class="form-group">
                                <input type="text" class="form-control rounded-left" 
                                    placeholder="Email" 
                                    required 
                                    v-model = "User.UserEmail"
                                    @blur = "validateFieldRequired($event)"
                                    nameToValidate = "Email"
                                    fieldName = "UserEmail"
                                >
                                <span class="tooltiptext"></span>
                            </div>
                            <div class="form-group d-flex">
                                <input type="password" class="form-control rounded-left" 
                                    placeholder="Mật khẩu" 
                                    required 
                                    v-model = "User.PassWord"
                                    @blur = "validateFieldRequired($event)"
                                    nameToValidate = "Mật khẩu"
                                    fieldName = "PassWord"
                                >
                                <span class="tooltiptext"></span>
                            </div>
                            
                            <div class="form-group">
                                <button type="button" class="btn btn-primary rounded submit p-3 px-5" v-on:click = "btnLogin">Đăng nhập</button>
                            </div>
                        </form>
                    </div>
                </div>
				
			</div>
		</div>
	</section>
</template>

<script>
import axios from 'axios'
import {ToastJS} from '../assets/js/common/toastJs'
import {Resource} from '../assets/js/common/resource' 
import {Common} from '../assets/js/common/common' 

export default {
    data(){
        return{
            User : {
                UserEmail : "",
                PassWord : ""
            },
            checkValidate : true
        }
    },

    methods : {

        /**
         * Method thực hiện validate các trường bắt buộc nhập
         * CreatedBy : DNSon
        */
        validateFieldRequired : function(event){
            try {

                // var self = this;
                var input = event.target;
                var fieldName = input.getAttribute('fieldname');
                var nameToValidate = input.getAttribute('nameToValidate');
                var value = this.User[fieldName];
                var tootlTip = input.parentElement.querySelector('.tooltiptext');
                //Bắt buộc nhập
                if(!value){
                    // self.listFieldNotValidRequired.push(nameToValidate);
                    input.classList.add('border-red');
                    tootlTip.classList.add("showTooltip")
                    tootlTip.innerText = Resource[Common.LanguageCode].Validate.Required(nameToValidate);
                    input.setAttribute('validate' , false)
                    this.checkValidate = false;
                }
                else{
                    input.classList.remove('border-red');
                    tootlTip.classList.remove("showTooltip")
                    input.removeAttribute('validate')
                }
            } catch (error) {
                console.log(error)
            }
        },

        /**
         * Method việc đăng nhập
         * CreatedBy : DNSon 
        */
        btnLogin(){
            let me = this;
            var loginValid =  me.$refs.LoginRef;
            me.checkValidate = true;
            var inputRequires = loginValid.querySelectorAll('input[required]');
            for(let inputRequired of inputRequires)
            {
                inputRequired.focus();
                inputRequired.blur();
            }
            
            if(me.checkValidate)
            {
                axios.post("https://localhost:44397/api/v1/Login/LoginAPI" , me.User)
                .then((res) => {
                    if(res.data)
                    {
                        this.$emit('changeAuthen',res.data);
                        this.$emit('showToastSuccess' , ToastJS.loginSuccess);
                    }
                    else{
                        this.$emit('showToastWarning', ToastJS.loginWarning)
                    }
                    
                })
                .catch(error => {
                    console.log(error);
                })
            }
            
        },
    }
}
</script>

<style>

</style>