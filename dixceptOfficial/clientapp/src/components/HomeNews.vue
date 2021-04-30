<template>
<v-container>
    <v-row class="mt-3">
        <v-divider></v-divider>
        <v-col cols="12" class="text-h2 text-center mb-2">News</v-col>
        <v-col cols="6" sm="3" v-for="(n, index) in news" :key="index">
            <v-card class="mx-auto">
                <v-img src="../assets/dixsept_header_logo.png" height="200px" contain class="news_img"></v-img>
                <v-card-subtitle>{{n.date}}</v-card-subtitle>
                <v-card-title class="sp_news_font sp_heihgt_padding_none">{{n.title}}</v-card-title>
            </v-card>
        </v-col>
    </v-row>
</v-container>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {

        },
    })
    export default class Home extends Vue {
        data() {
            return {
                news: {
                    one: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                    two: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                    three: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                    four: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                    five: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                    six: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                    seven: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                    eight: {
                        date: '2020/12/31',
                        title: "本日の活動について",
                        show: false
                    },
                }
            }
        }
    }
</script>

<style scoped>
@media screen and (max-width: 480px){
    .sp_news_font{
        font-size: 15px;
    }
    .sp_heihgt_padding_none{
        padding-top: 0px !important;
        padding-bottom: 0px !important;
    }

}
</style>
