<template>
    <div>
        <UserToolbarComponent  
            v-on:btnDeleteRecord = "btnDeleteRecord"
        />
        <UserGridComponent 
            v-bind:users = "users"
            v-on:insertuserIdToListId = "insertuserIdToListId"
        />

        <PopupValidateComponent 
            v-show="isShowDialogValidate" 
            v-bind:messageNotValid = "messageNotValid" 
            v-on:btnHideDialogNotValid = "btnHideDialogNotValid"
        />

        <PopupConfirmComponent 
            v-show = "isShowDialogConfirm"
            v-bind:messageConfirm = "messageConfirm"
            v-bind:isCancelSaveConfirm = "isCancelSaveConfirm"
            v-bind:isDeleteConfirm = "isDeleteConfirm"
            v-on:btnHideDialogConfirm = "btnHideDialogConfirm"
            v-on:btnNotHideDialogConfirm = "btnNotHideDialogConfirm"
            v-on:updateProduct = "updateProduct"
            v-on:btnConfirmDelete = "btnConfirmDelete"
        
        />

        <ToastSuccessComponent v-show = "isShowToastSuccess" v-bind:messageSuccess = "messageSuccess" />


    </div>
</template>

<script>

/* Import Component */
import UserToolbarComponent from '../components/Toolbar/UserToolbarComponent.vue'
import UserGridComponent from '../components/Grid/UserGridComponent.vue'
import PopupValidateComponent from './Popup/PopupValidateComponent.vue'
import PopupConfirmComponent from './Popup/PopupConfirmComponent.vue'
import ToastSuccessComponent from './Toast/ToastSuccessComponent.vue'

/* import js */
import {Resource} from '../assets/js/common/resource'
import {ToastJS} from '../assets/js/common/toastJs'

/* Import library */
import axios from 'axios'


export default {
    name : "user-component",
    components : {
        UserToolbarComponent,
        UserGridComponent,
        PopupValidateComponent,
        PopupConfirmComponent,
        ToastSuccessComponent
    },
    data(){
        return{
            users : [],
            isShowLoader : false,
            isShowDialogConfirm : false,
            currentPage : 1,
            listUserIdToDelete : [],
            isShowDialogValidate : false,
            messageNotValid :"",
            isCancelSaveConfirm : false,
            isDeleteConfirm : false,
            isShowToastSuccess : false,
        }
    },

    methods : {

        /**
         * Method dùng để xóa sản phẩm khi người dùng xác nhận xóa
         * CreatedBy : DNSon 
        */
        btnConfirmDelete : function()
        {
            try {
                let me = this;
                let listId = '';
                this.listUserIdToDelete.forEach(item => {
                    listId += item + ',';
                });
                listId = listId.slice(0,listId.length - 1);
                
                console.log(listId);
                
                //gọi API xóa 1 bản ghi của sản phẩm
                
                axios.delete(Resource.API.Host + Resource.API.User + `/deleteMulti?listId=${listId}`)
                    .then(() => {
                        me.isShowDialogConfirm = false;
                        //Ẩn bỏ các button của dialog confirm
                        me.isCancelSaveConfirm = false;
                        me.isDeleteConfirm = false;
                        me.showToastSuccess(ToastJS.deleteMessageSuccess);
                        this.listUserIdToDelete = [];
                        me.getData();
                    })
                    .catch(() => {
                        me.isShowDialogConfirm = false;
                        //Ẩn bỏ các button của dialog confirm
                        me.isCancelSaveConfirm = false;
                        me.isDeleteConfirm = false;
                    })
            } catch (error) {
                console.log(error)
            }
        },

        /**
         * Method dùng để show toast thông báo Thêm/Sửa thành công nhân viên
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
         * Method dùng để đóng popup thêm/sửa sản phẩm
         * CreatedBy : DNSon
        */
        btnHideDialogConfirm : function(){
            try {
                this.isShowDialogConfirm = false;
                this.showDialog = false;
                //Ẩn bỏ các button của dialog confirm
                this.isCancelSaveConfirm = false;
                this.isDeleteConfirm = false;
            } catch (error) {
                console.log(error);
            }
        },


        /**
         * 
         * 
         * Method xác nhận việc hủy đóng popup thêm/sửa sản phẩm
         * CreatedBy : DNSon 
        */
        btnNotHideDialogConfirm : function()
        {
            try {
                this.isShowDialogConfirm = false;
                this.isCancelSaveConfirm = false;
                this.isDeleteConfirm = false;
            } catch (error) {
                console.log(error);
            }
        },

        insertuserIdToListId : function(listIdSelectedRecord)
        {
            this.listUserIdToDelete = listIdSelectedRecord;
        },

         /**
         * Xử lý khi nhấn button Hủy trên dialog thông báo not valid các trường bắt buộc nhập
         * CreatedBy : DNSon (22/11/2021)
         */
         btnHideDialogNotValid : function()
        {
            try {
                // this.ListFieldNotValidRequired = [];
                this.messageNotValid = "";
                this.isShowDialogValidate = false;
                
            } catch (error) {
                console.log(error)
            }
        },

        /**
         * Sự kiện dùng để xóa các bản ghi được chọn 
         * CreatedBy : DNSon (19/11/2021)
        */
        btnDeleteRecord : function()
        {
            try {
                if(this.listUserIdToDelete.length == 0)
                {
                    this.showDialogNotValid(ToastJS.deleteMessageWarning)
                }
                else{

                    this.isShowDialogConfirm = true;
                    this.isDeleteConfirm = true;
                    this.messageConfirm = Resource.VN.MessageDialogConfirm.deleteMessage;
                    
                }
            } catch (error) {
                console.log(error)
            }
        },

        /**
         * Method show dialog not valid
        */
        showDialogNotValid : function(message)
        {
            this.messageNotValid = '<span class = "text-notvalid-dialog">' +  message  + '</span>';
            this.isShowDialogValidate = true;
        },


         /**
         * Lấy danh sách người dùng
         * CreatedBy : DNSon (04/08/2022)
        */
        getData(){
            var me = this;
            this.isShowLoader = true;
            // axios.get(Resource.API.Host + Resource.API.GetProductApi)
            axios.get(Resource.API.Host + Resource.API.User + Resource.API.searchUser(Resource.SearchPaging.textSearch, Resource.SearchPaging.PageSize ,  me.currentPage))
            .then(res => {
                this.isShowLoader = false;
                me.users = res.data.data;
                // me.totalPage = res.data.totalPage;
                // me.totalRecord = res.data.totalRecord;
            })
            .catch(error => {
                // this.isShowLoader = false;
                console.log(error)
            })
        },
    },

    created() {
        this.getData();
    },
}
</script>

<style>

</style>