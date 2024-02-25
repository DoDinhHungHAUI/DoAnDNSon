<template lang="">
    <div class="toast-model">
        <div class="m-toast warning-toast">
            <div class="icon-toast toast-icon-warning">
                <i class="fa fa-exclamation-triangle" aria-hidden="true"></i>
            </div>
            <div class="content-toast">{{messageWarning}}</div>
        </div>
    </div>
</template>
<script>
export default {
    props : ['messageWarning']
}
</script>
<style lang="">
    
</style>