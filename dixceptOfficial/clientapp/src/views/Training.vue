<template>
    <div>
        <v-card>
            <v-row justify="center">
                <v-col cols="10" class="text-sm-h3 text-h6 boder_left mt-5">VS 練習試合相手名</v-col>
                <v-col cols="10" class="subtitle-2">2020/12/31</v-col>
            </v-row>
            <v-row justify="center">
                <v-col cols="10">
                    <v-img :src="require('../assets/NoImg.png')" width="100%" height="60vh"></v-img>
                </v-col>
            </v-row>
            <v-row justify="center">
                <v-col cols="10">
                    <v-row>
                        <v-col class="text-h5" cols="6" sm="2">1本目</v-col>
                        <v-col class="text-h5" cols="6" sm="2">2-2</v-col>
                        <v-col class="text-h5" cols="4" sm="4">得点者</v-col>
                        <v-col class="subtitle-2" cols="8" sm="4">太郎、太郎、太郎</v-col>
                    </v-row>
                </v-col>
            </v-row>
            <v-row justify="center">
                <v-col cols="10">
                    <v-row>
                        <v-col class="text-h5" cols="6" sm="2">2本目</v-col>
                        <v-col class="text-h5" cols="6" sm="2">2-2</v-col>
                        <v-col class="text-h5" cols="4" sm="4">得点者</v-col>
                        <v-col class="subtitle-2" cols="8" sm="4">太郎、太郎、太郎</v-col>
                    </v-row>
                </v-col>
            </v-row>
            <v-row justify="center">
                <v-col cols="10">
                    <v-row>
                         <v-col class="text-h5" cols="6" sm="2">3本目</v-col>
                        <v-col class="text-h5" cols="6" sm="2">2-2</v-col>
                        <v-col class="text-h5" cols="4" sm="4">得点者</v-col>
                        <v-col class="subtitle-2" cols="8" sm="4">太郎、太郎、太郎</v-col>
                    </v-row>
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
    import { Component, Prop, Vue } from 'vue-property-decorator';
    @Component
    export default class Training extends Vue {
        @Prop({ type: String, required: true })
        id: String;
    }
</script>

<style scoped>
    .boder_left {
        border-left: solid 5px green;
    }
</style>
