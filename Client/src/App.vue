<template>
 
 <div>
 <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <!-- <div class="preloader">
        <div class="lds-ripple">
            <div class="lds-pos"></div>
            <div class="lds-pos"></div>
        </div>
    </div>
     -->

    <div v-if="authentication" id="main-wrapper" data-navbarbg="skin6" data-theme="light" data-layout="vertical" data-sidebartype="full" data-boxed-layout="full">
        <header class="topbar" data-navbarbg="skin6">
            <HeaderComponent />
        </header>

        <aside class="left-sidebar" data-sidebarbg="skin5">
            <SidebarComponent />
        </aside>
        
        <div class="page-wrapper" style="display: block;">
            <ContentComponent />
        </div>

    </div>

    <div v-else>
      <LoginComponentVue  
        v-on:changeAuthen = "changeAuthen" 
        v-on:showToastSuccess = "showToastSuccess"
        v-on:showToastWarning = "showToastWarning"
        />
    </div>
    <ToastSuccessComponent v-show = "isShowToastSuccess" v-bind:messageSuccess = "messageSuccess" />
    <ToastWarningComponent v-show = "isShowToastWarning" v-bind:messageWarning = "messageWarning" />

</div>

</template>

<script>

import HeaderComponent from './components/HeaderComponent.vue'
import SidebarComponent from './components/SidebarComponent.vue'
import ContentComponent from './components/ContentComponent.vue'
import LoginComponentVue from './components/LoginComponent.vue'
import ToastSuccessComponent from './components/Toast/ToastSuccessComponent.vue'
import ToastWarningComponent from './components/Toast/ToastWarningComponent.vue'

export default {
  name: 'App',
  components: {
    HeaderComponent,
    SidebarComponent,
    ContentComponent,
    LoginComponentVue,
    ToastSuccessComponent,
    ToastWarningComponent
  },
  data(){
    return{
       authentication:true,
       isShowToastSuccess : false,
       messageSuccess : "",
       isShowToastWarning : false,
       messageWarning : ""
    }
  },
  
  methods :
  {
    changeAuthen : function(checkAuth)
    {
      this.authentication = checkAuth;
    },

      /**
     * Method dùng để show toast 
     * CreatedBy : DNSon
     */
      showToastSuccess : function(message){
        try {
            this.messageSuccess = message;
            this.isShowToastSuccess = true;
            setTimeout(() => {
                this.isShowToastSuccess = false
            } , 3000)
        } catch (error) {
            console.log(error);
        }
    },

    /**
     * Method dùng để show toast 
     * CreatedBy : DNSon
     */
     showToastWarning : function(message){
        try {
            this.messageWarning = message;
            this.isShowToastWarning = true;
            setTimeout(() => {
                this.isShowToastWarning = false
            } , 3000)
        } catch (error) {
            console.log(error);
        }
    },

  }
}
</script>

<style>

  @import url('./assets/main.css');
</style>
