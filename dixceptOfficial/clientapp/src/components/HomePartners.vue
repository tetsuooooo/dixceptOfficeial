<template>
    <v-row justify="center">
        <v-divider></v-divider>
        <v-col cols="12" class="text-h2 text-center">Partners</v-col>
        <v-col cols="11">
            <v-row justify="center">
                <v-col cols="6">
                    <v-card>
                        <v-img src="../assets/afford.jpg" width="100%" height="300" class="partner_img" contain></v-img>
                    </v-card>
                </v-col>
                <v-col cols="6">
                    <v-card>
                        <v-img src="../assets/partner.png" width="100%" height="300" class="partner_img" contain></v-img>
                    </v-card>
                </v-col>
            </v-row>
        </v-col>
    </v-row>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {
            //HelloWorld,
        },
    })
    export default class Home extends Vue {

    }
</script>

<style scoped>
@media screen and (max-width: 480px){
  .partner_img{
      height: 100px !important;
  }

}
</style>
