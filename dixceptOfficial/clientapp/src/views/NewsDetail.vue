<template>
    <div>
        <v-card class="mt-5">
            <v-row justify="center">
                <v-col cols="10" class="text-sm-h3 text-h6 boder_left mt-5">タイトル</v-col>
                <v-col cols="10" class="subtitle-2">2020/12/31</v-col>
            </v-row>
            <v-row justify="center">
                <v-col cols="10">
                    <v-img :src="require('../assets/NoImg.png')" width="100%" height="60vh"></v-img>
                </v-col>
            </v-row>
            <v-row justify="center" class="mb-5">
                <v-col cols="10" class="text-h5">コメント</v-col>
                <v-col cols="10">
                    samplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesample
                    samplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesample
                    samplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesamplesample
                </v-col>
            </v-row>
        </v-card>
    </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue, } from 'vue-property-decorator';

    @Component
    export default class NewsDetail extends Vue {
        data() {
            return {

            }
        }
        beforeCreate() {
            console.log(this.$props)
        }

        @Prop({ type: String, required: true })
        id: String;
    }




</script>

<style scoped>
    .boder_left {
        border-left: solid 5px green;
    }
</style>
