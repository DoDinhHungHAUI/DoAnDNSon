<template>
  <div class="row filter-toobar-product">
        <div class="col-5 align-self-center">
            <h4 class="page-title">Danh sách người dùng</h4>
        </div>
        <div class="col-7">
            <div class="wrap-button-header">
                <!-- <button type="button" class="btn btn-success btn-add-product">
                    <span>
                        <i class="fa fa-plus" aria-hidden="true"></i>
                    </span>
                    Thêm tài khoản
                </button> -->

                <button type="button" class="btn btn-danger btn-delete-product"  v-on:click = "btnDeleteRecord">
                    <span>
                        <i class="fa fa-trash" aria-hidden="true"></i>
                    </span>
                    Xóa tài khoản
                </button>

            </div>
        </div>
    </div>
</template>

<script>
export default {
    methods : {
       /** 
         * Sự kiện dùng để xóa các bản ghi được chọn 
         * CreatedBy : DNSon
        */
        btnDeleteRecord : function()
        {
            this.$emit("btnDeleteRecord");    
        },  
    }
}
</script>

<style>

</style>